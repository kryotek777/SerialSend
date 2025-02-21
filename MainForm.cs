using System;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace SerialSend
{
    public partial class MainForm : Form
    {
        private static readonly OpenFileDialog openFileDialog = new();
        private static readonly int[] commonBaudRates = { 110, 150, 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200, 230400, 460800, 921600 };
        private static readonly int[] commonDataBits = { 5, 6, 7, 8 };

        public MainForm()
        {
            InitializeComponent();
        }

        private void SerialSend(string name, int baudRate, Parity parity, int dataBits, StopBits stopBits, string filename)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Port name cannot be null or whitespace.", nameof(name));

            if (string.IsNullOrWhiteSpace(filename) || !File.Exists(filename))
                throw new ArgumentException("File not found.", nameof(filename));

            using var port = new SerialPort(name, baudRate, parity, dataBits, stopBits);
            var data = File.ReadAllBytes(filename);

            port.Open();
            port.Write(data, 0, data.Length);
        }

        protected override void OnLoad(EventArgs e)
        {
            // Populate Ports
            var ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                serialPortCombo.Items.AddRange(ports);
                serialPortCombo.SelectedIndex = 0;
            }
            else
            {
                serialPortCombo.Items.Clear();
            }

            // Populate Baud Rates
            foreach (var item in commonBaudRates)
            {
                baudRateCombo.Items.Add(item);
            }
            baudRateCombo.SelectedItem = 9600;

            // Populate Parity options
            parityCombo.Items.AddRange(Enum.GetNames<Parity>().ToArray());
            parityCombo.SelectedItem = nameof(Parity.None);

            // Populate Data Bits
            foreach (var item in commonDataBits)
            {
                dataBitsCombo.Items.Add(item);
            }
            dataBitsCombo.SelectedItem = 8;

            // Populate Stop Bits
            stopBitsCombo.Items.AddRange(Enum.GetNames<StopBits>().ToArray());
            stopBitsCombo.SelectedItem = nameof(StopBits.One);

            base.OnLoad(e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            var fileName = filePathTb.Text;
            if (string.IsNullOrWhiteSpace(fileName) || !File.Exists(fileName))
            {
                MessageBox.Show("Per favore seleziona un file valido", "File non valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var portName = serialPortCombo.Text;
            if (string.IsNullOrWhiteSpace(portName))
            {
                MessageBox.Show("Per favore seleziona una porta valida", "Porta non valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(baudRateCombo.Text, out int baudRate))
            {
                MessageBox.Show("Per favore seleziona un baud rate valido", "Baud Rate non valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Enum.TryParse<Parity>(parityCombo.Text, out Parity parity))
            {
                MessageBox.Show("Per favore seleziona un parity valido", "Parity non valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(dataBitsCombo.Text, out int dataBits))
            {
                MessageBox.Show("Per favore seleziona un numero valido per i data bits.", "Data Bits non validi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Enum.TryParse<StopBits>(stopBitsCombo.Text, out StopBits stopBits))
            {
                MessageBox.Show("Per favore seleziona degli stop bits validi.", "Stop Bits non validi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SerialSend(portName, baudRate, parity, dataBits, stopBits, fileName);
                MessageBox.Show("Dati inviati con successo", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error nell'invio dei dati: {ex.Message}.\nAlcuni dei parametri potrebbero non essere supportati dalla connessione selezionata.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathTb.Text = openFileDialog.FileName;
            }
        }
    }
}
