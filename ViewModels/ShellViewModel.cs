using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartApp.Models;

namespace ShoppingCartApp.ViewModels
{
	class ShellViewModel : Screen
	{
		private string _firstName = "Ryan";
		private string _lastName = "Probst";
		private string _fullName;

		public string GetData()
		{
			string data;
			DatabaseModel query = new DatabaseModel();
			data = query.Connection();
			return data;
			
		}

		
		public string FirstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				_firstName = value;
				NotifyOfPropertyChange(() => FirstName);
				NotifyOfPropertyChange(() => LastName);
				NotifyOfPropertyChange(() => FullName);
			}
		}

		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				_lastName = value;
				NotifyOfPropertyChange(() => FirstName);
				NotifyOfPropertyChange(() => LastName);
				NotifyOfPropertyChange(() => FullName);
			}
		}

		public string FullName
		{
			get 
			{
			
				return $"{ FirstName } { LastName}";
			}

			set 
			{
				
				_fullName = value;
				NotifyOfPropertyChange(() => FirstName);
				NotifyOfPropertyChange(() => LastName);
				NotifyOfPropertyChange(() => FullName);
			}
		}



	}
}
