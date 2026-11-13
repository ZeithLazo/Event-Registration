using BusinessLogicEvent;

namespace EventRegistrationForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            LoadEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }


        private void LoadEvents()
        {
            lstEvents.Items.Clear();
            List<string> events = Methods.TicketService.GetEvents();

            foreach (string name in events)
            {
                lstEvents.Items.Add(name);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int index = lstEvents.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Please select an event.");
                return;
            }

            List<string> events = Methods.TicketService.GetEvents();
            string date = DateTime.Now.ToString("dd/MM/yyyy");

            txtTicket.Text = Methods.TicketService.TicketInfo(events[index], date);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}