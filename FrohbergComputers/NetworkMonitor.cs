using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Timers;

namespace FrohbergComputers
{
    public class NetworkMonitor
    {
        private readonly Label _adapterNameLabel;
        private readonly Label _macAddressLabel;
        private readonly Label _ipAddressLabel;
        private readonly Label _subnetMaskLabel;
        private readonly Label _defaultGatewayLabel;
        private readonly Label _dnsServersLabel;
        private readonly Label _dhcpEnabledLabel;
        private readonly Label _bytesSentLabel;
        private readonly Label _bytesReceivedLabel;
        private long _previousBytesSent;
        private long _previousBytesReceived;
        private NetworkInterface _networkInterface;
        private System.Timers.Timer _timer;

        public NetworkMonitor(
            Label adapterNameLabel, Label macAddressLabel, Label ipAddressLabel,
            Label subnetMaskLabel, Label defaultGatewayLabel, Label dnsServersLabel,
            Label dhcpEnabledLabel, Label bytesSentLabel, Label bytesReceivedLabel)
        {
            _adapterNameLabel = adapterNameLabel;
            _macAddressLabel = macAddressLabel;
            _ipAddressLabel = ipAddressLabel;
            _subnetMaskLabel = subnetMaskLabel;
            _defaultGatewayLabel = defaultGatewayLabel;
            _dnsServersLabel = dnsServersLabel;
            _dhcpEnabledLabel = dhcpEnabledLabel;
            _bytesSentLabel = bytesSentLabel;
            _bytesReceivedLabel = bytesReceivedLabel;
        }

        public void StartMonitoring()
        {
            _networkInterface = NetworkInterface.GetAllNetworkInterfaces()
                .FirstOrDefault(ni => ni.OperationalStatus == OperationalStatus.Up);

            if (_networkInterface == null)
            {
                SetLabelText(_adapterNameLabel, "No active network adapter found.");
                return;
            }

            UpdateNetworkInfo();

            _timer = new System.Timers.Timer(1000); // Update every 1 second
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Start();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            UpdateNetworkTraffic();
        }

        public void UpdateNetworkInfo()
        {
            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces()
                .FirstOrDefault(ni => ni.OperationalStatus == OperationalStatus.Up);

            if (networkInterfaces != null)
            {
                UpdateAdapterName(networkInterfaces);
                UpdateMacAddress(networkInterfaces);
                UpdateIpAddress(networkInterfaces);
                UpdateSubnetMask(networkInterfaces);
                UpdateDefaultGateway(networkInterfaces);
                UpdateDnsServers(networkInterfaces);
                UpdateDhcpStatus(networkInterfaces);
            }
            else
            {
                SetLabelText(_adapterNameLabel, "No active network adapter found.");
            }
        }

        public void UpdateNetworkTraffic()
        {
            if (_networkInterface != null)
            {
                var statistics = _networkInterface.GetIPv4Statistics();

                long bytesSent = statistics.BytesSent - _previousBytesSent;
                long bytesReceived = statistics.BytesReceived - _previousBytesReceived;

                _previousBytesSent = statistics.BytesSent;
                _previousBytesReceived = statistics.BytesReceived;

                SetLabelText(_bytesSentLabel, $"{FormatBytes(bytesSent)}");
                SetLabelText(_bytesReceivedLabel, $"{FormatBytes(bytesReceived)}");
            }
        }

        private string FormatBytes(long bytes)
        {
            const int scale = 1024;
            string[] orders = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;

            while (bytes >= scale && order < orders.Length - 1)
            {
                order++;
                bytes /= scale;
            }

            return $"{bytes:0.##} {orders[order]}";
        }

        private void UpdateAdapterName(NetworkInterface networkInterface)
        {
            SetLabelText(_adapterNameLabel, networkInterface.Name);
        }

        private void UpdateMacAddress(NetworkInterface networkInterface)
        {
            string macAddress = string.Join(":", networkInterface.GetPhysicalAddress()
                .GetAddressBytes().Select(b => b.ToString("X2")));
            SetLabelText(_macAddressLabel, macAddress);
        }

        private void UpdateIpAddress(NetworkInterface networkInterface)
        {
            var ipProperties = networkInterface.GetIPProperties();
            var ipAddress = ipProperties.UnicastAddresses
                .FirstOrDefault(ip => ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?
                .Address.ToString();
            SetLabelText(_ipAddressLabel, ipAddress ?? "No IPv4 address found.");
        }

        private void UpdateSubnetMask(NetworkInterface networkInterface)
        {
            var ipProperties = networkInterface.GetIPProperties();
            var subnetMask = ipProperties.UnicastAddresses
                .FirstOrDefault(ip => ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?
                .IPv4Mask.ToString();
            SetLabelText(_subnetMaskLabel, subnetMask ?? "N/A");
        }

        private void UpdateDefaultGateway(NetworkInterface networkInterface)
        {
            var gateway = networkInterface.GetIPProperties().GatewayAddresses
                .Select(g => g.Address.ToString())
                .FirstOrDefault();
            SetLabelText(_defaultGatewayLabel, gateway ?? "N/A");
        }

        private void UpdateDnsServers(NetworkInterface networkInterface)
        {
            var dnsServers = string.Join(", ", networkInterface.GetIPProperties().DnsAddresses
                .Select(dns => dns.ToString()));
            SetLabelText(_dnsServersLabel, string.IsNullOrEmpty(dnsServers) ? "N/A" : dnsServers);
        }

        private void UpdateDhcpStatus(NetworkInterface networkInterface)
        {
            var dhcpEnabled = networkInterface.GetIPProperties().DhcpServerAddresses.Any();
            SetLabelText(_dhcpEnabledLabel, dhcpEnabled ? "Enabled" : "Disabled");
        }

        private void SetLabelText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() => label.Text = text));
            }
            else
            {
                label.Text = text;
            }
        }
    }
}