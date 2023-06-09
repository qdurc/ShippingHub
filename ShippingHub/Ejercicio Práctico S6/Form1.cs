using System;
using System.IO.Packaging;
using static System.Windows.Forms.AxHost;
using System.Net;
using System.Windows.Forms;

namespace Ejercicio_Práctico_S6
{
	public partial class Form1 : Form
	{
		Random num = new Random();
		List<Package> packages = new List<Package>();

		public Form1()
		{
			InitializeComponent();
			Back_BTN.Enabled = false;
			Add_BTN.Enabled = false;
			Remove_BTN.Enabled = false;
			Edit_BTN.Enabled = false;
			Next_BTN.Enabled = false;
		}
		public void ClearTXT()
		{
			Address_TXT.Text = string.Empty;
			City_TXT.Text = string.Empty;
			Zip_TXT.Text = string.Empty;
		}

		private void ScanNew_BTN_Click(object sender, EventArgs e)
		{
			ClearTXT();
			State_CMBOX.SelectedIndex = 0;
			ScanNew_BTN.Enabled = false;
			Add_BTN.Enabled = true;
			groupBox1.Enabled = true;

			int ID = Random.Shared.Next(10000, 100000);
			PackageID_TXT.Text = ID.ToString();
			string date = ArrivedAt_TXT.Text = DateTime.Now.ToString();
		}
		public void AddPackage()
		{
			int packageID = int.Parse(PackageID_TXT.Text);
			Package_LSTBOX.Items.Add(packageID);

			string address = Address_TXT.Text;
			string city = City_TXT.Text;
			int zip = int.Parse(Zip_TXT.Text);
			string state = State_CMBOX.Text;
			Package package = new Package(packageID, address, city, zip, state);
			packages.Add(package);

			ScanNew_BTN.Enabled = true;
			Back_BTN.Enabled = true;
			Add_BTN.Enabled = false;
			Remove_BTN.Enabled = true;
			Edit_BTN.Enabled = true;
			Next_BTN.Enabled = true;
			groupBox1.Enabled = false;
		}
		public bool FiveDigits()
		{
			bool fiveDigits = false;

			if (Zip_TXT.TextLength != 5)
			{
				MessageBox.Show("Zip code has to be 5 numeric digits ", "Warning", 0, MessageBoxIcon.Warning);
				return fiveDigits;
			}
			else
			{
				AddPackage();
				fiveDigits = true;
				return fiveDigits;
			}
		}
		public bool IsFilled()
		{
			bool isFilled = true;

			if (Address_TXT.Text == string.Empty || City_TXT.Text == string.Empty || Zip_TXT.Text == string.Empty)
			{
				isFilled = false;
				MessageBox.Show("Please, fill package information", "Warning!", 0, MessageBoxIcon.Warning);
				return isFilled;
			}
			else
			{
				FiveDigits();
				return isFilled;
			}
		}

		private void Add_BTN_Click(object sender, EventArgs e)
		{
			IsFilled();
		}

		private void Package_LSTBOX_SelectedIndexChanged(object sender, EventArgs e)
		{
			while (Package_LSTBOX.SelectedItem != null)
			{
				foreach (Package p in packages)
				{
					Package package = p as Package;
					int idBuscado = (int)Package_LSTBOX.SelectedItem;

					if (idBuscado == p.PackageID)
					{
						MessageBox.Show(
						$"Package: {package.PackageID}\n" +
						$"Address: {package.Address}\n" +
						$"City: {package.City}\n" +
						$"State: {package.State}\n" +
						$"Zip code: {package.Zip}"
						, "Package information", 0, MessageBoxIcon.Information);
					}
				}
				break;
			}
		}

		private void PackageByState_CMBOX_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (packages.Count != 0)
			{
				Package_LSTBOX.Items.Clear();
				foreach (Package p in packages)
				{
					Package package = p as Package;
					string state = (string)PackageByState_CMBOX.SelectedItem;
					if (state == p.State)
					{
						Package_LSTBOX.Items.Add(p.PackageID);
					}
				}
			}
		}
		public void UpdateButton()
		{
			Button button2 = new Button();
			button2.Text = "Update";
			button2.Location = Edit_BTN.Location;
			button2.Size = Edit_BTN.Size;
			button2.Click += Update_BTN_Click;
			Controls.Add(button2);
		}

		private void Edit_BTN_Click(object sender, EventArgs e)
		{
			if (Package_LSTBOX.SelectedIndex != -1)
			{
				groupBox1.Enabled = true;
				UpdateButton();
				Edit_BTN.Visible = false;

				foreach (Package p in packages)
				{
					Package package = p as Package;
					int idSeleccionado = (int)Package_LSTBOX.SelectedItem;

					if (idSeleccionado == p.PackageID)
					{
						PackageID_TXT.Text = p.PackageID.ToString();
						Address_TXT.Text = p.Address;
						City_TXT.Text = p.City;
						State_CMBOX.Text = p.State;
						Zip_TXT.Text = p.Zip.ToString();
					}
				}
			}
			else
			{
				MessageBox.Show("Favor, selecciona el ID del paquete a editar", "Error", 0, MessageBoxIcon.Exclamation);
			}
		}

		private void Update_BTN_Click(object sender, EventArgs e)
		{
			foreach (Package p in packages)
			{
				Package package = p as Package;
				int idSeleccionado = (int)Package_LSTBOX.SelectedItem;

				if (idSeleccionado == p.PackageID)
				{
					string newAddress = Address_TXT.Text;
					string newCity = City_TXT.Text;
					int newZip = int.Parse(Zip_TXT.Text);
					string newState = State_CMBOX.Text;

					p.Address = newAddress;
					p.City = newCity;
					p.State = newState;
					p.Zip = newZip;
				}
			}
			Controls.Remove((Button)sender);
			Edit_BTN.Visible = true;
			groupBox1.Enabled = false;
		}

		private void Remove_BTN_Click(object sender, EventArgs e)
		{
			if (Package_LSTBOX.SelectedIndex != -1)
			{
				int item = (int)Package_LSTBOX.SelectedItem;
				Package_LSTBOX.Items.Remove(item);
				ClearTXT();
				PackageID_TXT.Text = string.Empty;
				object idSeleccionado = Package_LSTBOX.SelectedItem;
				Del(idSeleccionado);
			}
			else
			{
				MessageBox.Show("Favor, selecciona el ID del paquete a eliminar", "Error", 0, MessageBoxIcon.Exclamation);
			}
		}
		public void Del(object id)
		{
			foreach (Package p in packages)
			{
				Package package = p as Package;
				if (object.Equals(package.PackageID, id))
				{
					packages.Remove(package);
				}
			}
		}
		int indiceActual = 0;
		public void MostrarPersona()
		{
			if (packages.Count > 0)
			{
				Package package = packages[indiceActual];
				PackageID_TXT.Text = package.PackageID.ToString();
				Address_TXT.Text = package.Address;
				City_TXT.Text = package.City;
				State_CMBOX.Text = package.State;
				Zip_TXT.Text = package.Zip.ToString();
			}
		}

		private void Back_BTN_Click(object sender, EventArgs e)
		{
			indiceActual--;
			if (indiceActual < 0)
			{
				indiceActual = packages.Count - 1;
			}
			MostrarPersona();
		}

		private void Next_BTN_Click(object sender, EventArgs e)
		{
			indiceActual++;
			if (indiceActual >= packages.Count)
			{
				indiceActual = 0;
			}
			MostrarPersona();
		}
	}
}