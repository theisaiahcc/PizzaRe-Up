namespace PizzaRe_up
{
    public partial class PizzaAppForm : Form
    {
        public PizzaAppForm()
        {
            InitializeComponent();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Edit editForm = new Edit();
            editForm.ShowDialog();
        }

        private void btnPreset_Click(object sender, EventArgs e)
        {
            Preset presetForm = new Preset();
            presetForm.ShowDialog();
        }

        private void PizzaAppForm_Load(object sender, EventArgs e)
        {

        }
    }
}