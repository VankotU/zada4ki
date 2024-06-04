using ProjectVeganStore.Controller;
using ProjectVeganStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVeganStore
{
    public partial class Form1 : Form
    {
        VeganController veganController = new VeganController();
        VeganTypeController veganTypeController = new VeganTypeController();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadRecord(Vegans vegan)
        {
            txt_Id.BackColor = Color.White;
            txt_Id.Text = vegan.Id.ToString();
            txt_Name.Text = vegan.Name;
            txt_Description.Text = vegan.Description;
            txt_Price.Text = vegan.Price.ToString();
            cmb_Type.Text = vegan.Types.Name;
        }
        private void ClearScreen()
        {
            txt_Id.BackColor = Color.White;
            txt_Id.Clear();
            txt_Name.Clear();
            txt_Description.Clear();
            txt_Price.Clear();
            cmb_Type.Text = "";
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            List<VeganType> allVeganTypes = veganTypeController.GetAllTypes();
            cmb_Type.DataSource = allVeganTypes;
            cmb_Type.DisplayMember = "Name";
            cmb_Type.ValueMember = "Id";
            btn_SelectAll_Click(sender, e);
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            List<Vegans> allVegans = veganController.GetAll();
            listBox1.Items.Clear();
            foreach (var item in allVegans)
            {
                listBox1.Items.Add($"{item.Id}.Name - {item.Name} - Price: {item.Price}, Description - {item.Description}, Type - {item.Types.Name}");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text) || txt_Name.Text == "")
            {
                MessageBox.Show("Insert data!");
                txt_Name.Focus();
                return;
            }
            Vegans newVegans = new Vegans();
            newVegans.Price = double.Parse(txt_Price.Text);
            newVegans.Name = txt_Name.Text;
            newVegans.Description = txt_Description.Text;
            newVegans.Vegan_type_Id = (int)cmb_Type.SelectedValue;

            veganController.Create(newVegans);
            MessageBox.Show("Item successfully added!");
            ClearScreen();
            btn_SelectAll_Click(sender, e);
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txt_Id.Text) || txt_Id.Text.All(char.IsDigit))
            {
                MessageBox.Show("You must insert ID for searching!");
                txt_Id.BackColor = Color.Red;
                txt_Id.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txt_Id.Text);
            }
            Vegans findedVegan = veganController.Get(findId);
            if (findedVegan == null)
            {
                MessageBox.Show("There isn't such item in Database \n Insert ID for search!");
                txt_Id.BackColor = Color.Red;
                txt_Id.Focus();
                return;
            }
            LoadRecord(findedVegan);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txt_Id.Text) || txt_Id.Text.All(char.IsDigit))
            {
                MessageBox.Show("You must insert ID for searching!");
                txt_Id.BackColor = Color.Red;
                txt_Id.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txt_Id.Text);
            }
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                Vegans findedVegan = veganController.Get(findId);
                if (findedVegan == null)
                {
                    MessageBox.Show("There isn't such item in Database \n Insert ID for search!");
                    txt_Id.BackColor = Color.Red;
                    txt_Id.Focus();
                    return;
                }
                LoadRecord(findedVegan);
            }
            else
            {
                Vegans updatedVegan = new Vegans();
                updatedVegan.Name = txt_Name.Text;
                updatedVegan.Description = txt_Description.Text;
                updatedVegan.Price = double.Parse(txt_Price.Text);
                updatedVegan.Vegan_type_Id = (int)cmb_Type.SelectedValue;

                veganController.Update(findId, updatedVegan);
            }
            btn_SelectAll_Click(sender, e);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txt_Id.Text) || txt_Id.Text.All(char.IsDigit))
            {
                MessageBox.Show("You must insert ID for searching!");
                txt_Id.BackColor = Color.Red;
                txt_Id.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txt_Id.Text);
            }
            Vegans findedVegan = veganController.Get(findId);
            if (findedVegan == null)
            {
                MessageBox.Show("There isn't such item in Database \n Insert ID for search!");
                txt_Id.BackColor = Color.Red;
                txt_Id.Focus();
                return;
            }
            LoadRecord(findedVegan);

            DialogResult answer = MessageBox.Show("Do you really want to delete item number "+findId+" ?", "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                veganController.Delete(findId);
            }
            btn_SelectAll_Click(sender, e);
        }
    }
}
