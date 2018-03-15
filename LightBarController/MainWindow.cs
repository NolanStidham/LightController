using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace LightBarController
{
    public partial class MainWindow : Form
    {
        // Global Variables

        static SerialPort serialPort;

        //Form 1 Constructor

        public MainWindow()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM3", 57600);
            serialPort.Open();
        }

        // Methods

        /// <summary>
        /// This method sends a single string representing the color the user wants to display
        /// to the light bar controller in the form of three ints representing the RGB values of the said color
        /// </summary>
        /// <param name="r">The red value of the color</param>
        /// <param name="g">The green value of the color</param>
        /// <param name="b">The blue value of the color</param>
        public void sendRGBCode(int r, int g, int b) {
            string colorCode = createRGBValue(r, g, b);
            serialPort.Write(colorCode);
        }//end sendRGBCode

        /// <summary>
        /// This method takes a color code and creates the three digit sequence that the controler requires
        /// </summary>
        /// <param name="r">The red value</param>
        /// <param name="b">The blue value</param>
        /// <param name="g">The green value</param>
        /// <returns></returns>
        private string createRGBValue(int r, int g, int b) {
            string[] colors = new string[] { r.ToString(), g.ToString(), b.ToString() };
            for (int i = 0; i < 3; i++)
            {
                while (colors[i].Length < 3)
                {
                    colors[i] = colors[i].Insert(0, "0");
                }
            }

            string output = colors[0] + colors[1] + colors[2];
            Console.WriteLine(output);
            return output;
        }//end createRGBValue

        /// <summary>
        /// Opens the color menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorSelectorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// Sends the selected color to the light bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendColorButton_Click(object sender, EventArgs e)
        {
            Color selectedColor = colorPanel.BackColor;
            sendRGBCode(selectedColor.R*2, selectedColor.G, selectedColor.B);
        }

        // Event Handlers
    }
}
