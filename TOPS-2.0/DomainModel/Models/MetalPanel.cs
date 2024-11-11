using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
	public class MetalPanel
	{
		public int Id
		{
			get; set;
		}
		public string Substrate
		{
			get; set;
		}
		public float Thickness
		{
			get; set;
		}
		public string Finish
		{
			get; set;
		}
		public float Width
		{
			get; set;
		}
		public float Height
		{
			get; set;
		}
		public string Framing
		{
			get; set;
		}
		public string InstallHardware
		{
			get; set;
		}
		public bool IsSplit
		{
			get; set;
		}
		public string AdditionalHardware
		{
			get; set;
		}

		public MetalPanel(){}
		public MetalPanel(string sub,float thick, string fin,float w,float h,int? id = -1)
		{
			if (id != -1)
				Id = (int) id;
			Substrate = sub;
			Thickness = thick;
			Finish = fin;
			Width = w;
			Height = h;
		}
	}
}
