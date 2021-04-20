using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchuifPuzzel
{
  public partial class Form1 : Form
  {
    // 1 2 3
    // 4 5 6
    // 7 8 9

    private int emptyPos;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // zet de plaatjes op de buttons
      button1.Image = Image.FromFile("../../images/GroteKerkHaarlem1.png");
      button2.Image = Image.FromFile("../../images/GroteKerkHaarlem2.png");
      button3.Image = Image.FromFile("../../images/GroteKerkHaarlem3.png");
      button4.Image = Image.FromFile("../../images/GroteKerkHaarlem4.png");
      button5.Image = Image.FromFile("../../images/GroteKerkHaarlem5.png");
      button6.Image = Image.FromFile("../../images/GroteKerkHaarlem6.png");
      button7.Image = Image.FromFile("../../images/GroteKerkHaarlem7.png");
      button8.Image = Image.FromFile("../../images/GroteKerkHaarlem8.png");
      button9.Image = Image.FromFile("../../images/empty.png");

      // we starten met vakje 9 als leeg vakje
      emptyPos = 9;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // leeg vakje aansluitend op geklikt plaatje? dan plaatjes verwisselen
      if ((emptyPos == 2) || (emptyPos == 4))
      {
        SwapImages(1);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      // leeg vakje aansluitend op geklikt plaatje? dan plaatjes verwisselen
      if ((emptyPos == 1) || (emptyPos == 3) || (emptyPos == 5))
      {
        SwapImages(2);
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      // leeg vakje aansluitend op geklikt plaatje? dan plaatjes verwisselen
      if ((emptyPos == 2) || (emptyPos == 6))
      {
        SwapImages(3);
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      // leeg vakje aansluitend op geklikt plaatje? dan plaatjes verwisselen
      if ((emptyPos == 1) || (emptyPos == 5) || (emptyPos == 7))
      {
        SwapImages(4);
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      // TODO...
    }

    private void button6_Click(object sender, EventArgs e)
    {
      // leeg vakje aansluitend op geklikt plaatje? dan plaatjes verwisselen
      if ((emptyPos == 3) || (emptyPos == 5) || (emptyPos == 9))
      {
        SwapImages(6);
      }
    }

    private void button7_Click(object sender, EventArgs e)
    {
      // leeg vakje aansluitend op geklikt plaatje? dan plaatjes verwisselen
      if ((emptyPos == 4) || (emptyPos == 8))
      {
        SwapImages(7);
      }
    }

    private void button8_Click(object sender, EventArgs e)
    {
      // leeg vakje aansluitend op geklikt plaatje? dan plaatjes verwisselen
      if ((emptyPos == 5) || (emptyPos == 7) || (emptyPos == 9))
      {
        SwapImages(8);
      }
    }

    private void button9_Click(object sender, EventArgs e)
    {
      // leeg vakje aansluitend op geklikt plaatje? dan plaatjes verwisselen
      if ((emptyPos == 6) || (emptyPos == 8))
      {
        SwapImages(9);
      }
    }

    private void SwapImages(int clickedPos)
    {
      Button btn1 = GetButton(clickedPos);
      Button btn2 = GetButton(emptyPos);

      // swap images
      Image temp = btn1.Image;
      btn1.Image = btn2.Image;
      btn2.Image = temp;

      // update 'empty position'
      emptyPos = clickedPos;
    }

    private Button GetButton(int pos)
    {
      switch (pos)
      {
        case 1: return button1;
        case 2: return button2;
        case 3: return button3;
        case 4: return button4;
        case 5: return button5;
        case 6: return button6;
        case 7: return button7;
        case 8: return button8;
        case 9: return button9;
        default: return null;
      }
    }
  }
}