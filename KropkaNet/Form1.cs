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
                textBoxRise.Text = Convert.ToString(((IRise)listOfCreatedToy.SelectedItem).m_rise);
            }
            if (listOfCreatedToy.SelectedItem is IDive)
            {
                Dive.Visible = true;
                textBoxDive.Text = Convert.ToString(((IDive)listOfCreatedToy.SelectedItem).m_dive);
            }
            if (listOfCreatedToy.SelectedItem is IAccelerate)
            {
                Accelerate.Visible = true;
                textBoxAccelerate.Text = Convert.ToString(((IAccelerate)listOfCreatedToy.SelectedItem).m_accelerate);
            }
        }

        private void AccelerateIncrease_Click(object sender, EventArgs e)
        {
            IAccelerate accelerate = (IAccelerate)listOfCreatedToy.SelectedItem;
            accelerate.incAccelerate();
            textBoxAccelerate.Text = Convert.ToString(accelerate.m_accelerate);
        }

        private void accelerateDecrease_Click(object sender, EventArgs e)
        {
            IAccelerate accelerate = (IAccelerate)listOfCreatedToy.SelectedItem;
            accelerate.decAccelerate();
            textBoxAccelerate.Text = Convert.ToString(accelerate.m_accelerate);
        }

        private void diveDecrease_Click(object sender, EventArgs e)
        {
            IDive dive = (IDive)listOfCreatedToy.SelectedItem;
            dive.decDive();
            textBoxDive.Text = Convert.ToString(dive.m_dive);
        }
        private void diveIncrease_Click(object sender, EventArgs e)
        {
            IDive dive = (IDive)listOfCreatedToy.SelectedItem;
            dive.incDive();
            textBoxDive.Text = Convert.ToString(dive.m_dive);
        }

        private void riseDecrease_Click(object sender, EventArgs e)
        {
            IRise rise = (IRise)listOfCreatedToy.SelectedItem;
            rise.decRise();
            textBoxRise.Text = Convert.ToString(rise.m_rise);
        }

        private void riseIncrease_Click(object sender, EventArgs e)
        {
            IRise rise = (IRise)listOfCreatedToy.SelectedItem;
            rise.incRise();
            textBoxRise.Text = Convert.ToString(rise.m_rise);
        }
    }
}
