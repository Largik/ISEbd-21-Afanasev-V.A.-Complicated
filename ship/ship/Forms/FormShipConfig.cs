using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ship
{
    public partial class FormShipConfig : Form
    {
        Ship ship = null;
        private event Action<Ship> eventAddShip;
        private IDetails details = null;
        private Color dopColor = Color.Black; 
        public FormShipConfig()
        {
            InitializeComponent();
            foreach (var item in groupBoxColors.Controls)
            {
                if (item is Panel)
                {
                    ((Panel)item).MouseDown += panelColor_MouseDown;
                }
            }
            foreach (var item in groupBoxPipes.Controls)
            {
                if (item is Panel)
                {
                    ((Panel)item).MouseDown += labelPipe_MouseDown;
                }
            }
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTypeShip.Width, pictureBoxTypeShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 50, pictureBoxTypeShip.Width, pictureBoxTypeShip.Height);
                ship.DrawTransport(gr);
                pictureBoxTypeShip.Image = bmp;
            }
        }
        public void AddEvent(Action<Ship> ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new Action<Ship>(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }
        private void labelDefaultShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelDefaultShip.DoDragDrop(labelDefaultShip.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelMotorShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelMotorShip.DoDragDrop(labelMotorShip.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelDefaultShip":
                    ship = new DefaultShip((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "labelMotorShip":
                    ship = new MotorShip((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxCabin.Checked, checkBoxLines.Checked);
                    break;
                case "labelDefaultPipe":
                    if(ship is MotorShip)
                    {
                        details = new PipesDefault((int)numericUpDownPipe.Value, dopColor);
                        MotorShip mShip = (MotorShip)ship;
                        mShip.SetPipeForm(details);
                    }
                    break;
                case "labelRectanglePipe":
                    if (ship is MotorShip)
                    {
                        details = new PipeRectangle((int)numericUpDownPipe.Value, dopColor);
                        MotorShip mShip = (MotorShip)ship;
                        mShip.SetPipeForm(details);
                    }
                    break;
                case "labelTrianglePipe":
                    if (ship is MotorShip)
                    {
                        details = new PipeTriangle((int)numericUpDownPipe.Value, dopColor);
                        MotorShip mShip = (MotorShip)ship;
                        mShip.SetPipeForm(details);
                    }
                    break;
            }
            DrawShip();
        }
        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            ship?.SetMainColor((Color)(e.Data.GetData(typeof(Color))));
            DrawShip();
        }
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship is MotorShip)
            {
                MotorShip SHip = (MotorShip)ship;
                dopColor = ((Color)(e.Data.GetData(typeof(Color))));
                SHip.SetDopColor((Color)(e.Data.GetData(typeof(Color))));
                DrawShip();
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelPipe_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).DoDragDrop(((Label)sender).Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
    }
}
