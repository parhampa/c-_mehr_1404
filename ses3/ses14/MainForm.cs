/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 12/29/2025
 * Time: 10:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ses14
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
		void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			int tst;
			if(int.TryParse(textBox1.Text,out tst)==false){
				MessageBox.Show("please check input!!!");
				return;
			}
			int inp=int.Parse(textBox1.Text);
			int count=0;
			for(int i=1;i<=inp;i++){
				if(inp % i==0){
					listBox1.Items.Add(i);
					count++;
				}
			}
			label2.Text=count.ToString();
			if(count<=2){
				label4.Text="hast";
			}else{
				label4.Text="nist";
			}
			//MessageBox.Show(listBox1.Items.Count.ToString());
		}
		void Button2Click(object sender, EventArgs e)
		{
			for(int i=1;i<=100;i++){
				int count=0;
				for(int j=1;j<=i;j++){
					if(i%j==0){
						count++;
					}
				}
				if(count<=2){
					listBox1.Items.Add(i.ToString());
				}
			}
		}
	}
}
