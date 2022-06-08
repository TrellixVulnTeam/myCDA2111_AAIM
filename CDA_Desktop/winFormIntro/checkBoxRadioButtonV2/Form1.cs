
namespace checkBoxRadioButtonV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            

        private void Form1_Load(object sender, EventArgs e)
        {
            //gestion des Groupbox Visible
            cbCouleurFond.Tag = bgFond;
            cbCouleurCaractere.Tag = bgCaractere;
            cbCasse.Tag = bgCasse;

            //gestion du de couleur de la couleur de fond du label
            rbFondBleu.Tag = Color.Blue;
            rbFondRouge.Tag = Color.Blue;
            rbFondVert.Tag = Color.Vert;

        }

        private void TbInputUser_TextChanged(object sender, EventArgs e)
        {
            labelInputUserControl.Text = tbInputUser.Text;
            if (!String.IsNullOrEmpty(labelInputUserControl.Text))
            {
                gbChoix.Enabled = true;
            }
            else
            {
                gbChoix.Enabled = false;
            }
        }

        private void CheckBoxSelect(object sender, EventArgs e)
        {
            CheckBox myCheckBox = (CheckBox)sender;
            GroupBox myGroupBox = (GroupBox)myCheckBox.Tag;
            myGroupBox.Visible = myCheckBox.Checked;
        }

        private void RadioBoxSelect(object sender, EventArgs e)
        {
            RadioButton myRadioButton = (RadioButton)sender;
            Label myLabel = (Label)myRadioButton.Tag;
            myLabel.BackColor = myRadioButton.Checked;
        }
    }

        
}