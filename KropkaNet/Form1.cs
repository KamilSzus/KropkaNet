using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Accelerate.Visible = false;
            Dive.Visible = false;
            Rise.Visible = false;
        }

        private void deleteToy_Click(object sender, EventArgs e)
        {
            listOfCreatedToy.Items.Remove(listOfCreatedToy.SelectedItem);
        }

        private void addToy_Click(object sender, EventArgs e)
        {
            switch (listOfToy.SelectedItem)
            {
                case "Car":
                    listOfCreatedToy.Items.Add(new Car());
                    break;
                case "Submarine":
                    listOfCreatedToy.Items.Add(new Submarine());
                    break;
                case "Plane":
                    listOfCreatedToy.Items.Add(new Plane());
                    break;
                case "Computer":
                    listOfCreatedToy.Items.Add(new Computer());
                    break;
            }
        }

        private void listOfToy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listOfCreatedToy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Accelerate.Visible = false;
            Dive.Visible = false;
            Rise.Visible = false;
            if (listOfCreatedToy.SelectedItem is IRise)
            {
                Rise.Visible = true;
                textBoxRise.Text = Convert.ToString(((IRise)listOfCreatedToy.SelectedItem).Rise);
            }
            if (listOfCreatedToy.SelectedItem is IDive)
            {
                Dive.Visible = true;
                textBoxDive.Text = Convert.ToString(((IDive)listOfCreatedToy.SelectedItem).Dive);
            }
            if (listOfCreatedToy.SelectedItem is IAccelerate)
            {
                Accelerate.Visible = true;
                textBoxAccelerate.Text = Convert.ToString(((IAccelerate)listOfCreatedToy.SelectedItem).Accelerate);
            }
        }

        private void AccelerateIncrease_Click(object sender, EventArgs e)
        {
            IAccelerate accelerate = (IAccelerate)listOfCreatedToy.SelectedItem;
            if (accelerate != null)
            {
                accelerate.Accelerate++;// incAccelerate();
                textBoxAccelerate.Text = Convert.ToString(accelerate.Accelerate);
            }
        }

        private void accelerateDecrease_Click(object sender, EventArgs e)
        {
            IAccelerate accelerate = (IAccelerate)listOfCreatedToy.SelectedItem;
            if (accelerate != null)
            {
                accelerate.Accelerate--;
                textBoxAccelerate.Text = Convert.ToString(accelerate.Accelerate);
            }
        }

        private void diveDecrease_Click(object sender, EventArgs e)
        {
            IDive dive = (IDive)listOfCreatedToy.SelectedItem;
            if (dive != null)
            {
                dive.Dive--;
                textBoxDive.Text = Convert.ToString(dive.Dive);
            }
        }
        private void diveIncrease_Click(object sender, EventArgs e)
        {
            IDive dive = (IDive)listOfCreatedToy.SelectedItem;
            if (dive != null)
            {
                dive.Dive++;
                textBoxDive.Text = Convert.ToString(dive.Dive);
            }
        }

        private void riseDecrease_Click(object sender, EventArgs e)
        {
            IRise rise = (IRise)listOfCreatedToy.SelectedItem;
            if (rise != null)
            {
                rise.Rise--;
                textBoxRise.Text = Convert.ToString(rise.Rise);
            }
        }

        private void riseIncrease_Click(object sender, EventArgs e)
        {
            IRise rise = (IRise)listOfCreatedToy.SelectedItem;
            if (rise != null)
            {
                rise.Rise++;
                textBoxRise.Text = Convert.ToString(rise.Rise);
            }
        }
    }
}
