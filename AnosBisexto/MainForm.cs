/*
 * Created by SharpDevelop.
 * User: Ol
 * Date: 13/01/2018
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AnosBisexto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
	
			double inicial;
			inicial= Convert.ToInt32(textBox1.Text);
			double final;
			final= Convert.ToInt32(textBox2.Text);		
		//	bool podeSacar = (final <= inicial) && (final>0);
			
			double i=0;
			    
			    while (inicial<final)
			    {
	

				if (inicial % 4 == 0)
				{
				inicial = inicial + 1;
				i = i +1;;
				}
				
				else {
				inicial = inicial +1;
				}
				
			    }
			
			MessageBox.Show("A quantiade de numeros bisextos é: "+i);
			
		}
	}
}
