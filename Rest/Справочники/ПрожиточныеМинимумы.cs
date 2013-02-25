﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//ProzhitochnyeMinimumy
	[Маршрут("Справочники/ПрожиточныеМинимумы","")]
	public class ПрожиточныеМинимумыЗапрос: V82.СправочникиСсылка.ПрожиточныеМинимумы,IReturn<ПрожиточныеМинимумыЗапрос>
	{
	}
	[Маршрут("Справочники/ПрожиточныеМинимумы/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ПрожиточныеМинимумы/ПоСсылке","{Ссылка}")]
	public class ПрожиточныеМинимумыНайтиПоСсылке: V82.СправочникиСсылка.ПрожиточныеМинимумы,IReturn<ПрожиточныеМинимумыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ПрожиточныеМинимумы/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ПрожиточныеМинимумы/ПоКоду","{Код}")]
	public class ПрожиточныеМинимумыНайтиПоКоду: V82.СправочникиСсылка.ПрожиточныеМинимумы,IReturn<ПрожиточныеМинимумыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ПрожиточныеМинимумы/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ПрожиточныеМинимумы/ПоНаименованию","{Наименование}")]
	public class ПрожиточныеМинимумыНайтиПоНаименованию: V82.СправочникиСсылка.ПрожиточныеМинимумы,IReturn<ПрожиточныеМинимумыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ПрожиточныеМинимумы/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ПрожиточныеМинимумы/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрожиточныеМинимумы/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрожиточныеМинимумыВыбратьПоСсылке: V82.СправочникиСсылка.ПрожиточныеМинимумы,IReturn<ПрожиточныеМинимумыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрожиточныеМинимумы/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ПрожиточныеМинимумы/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрожиточныеМинимумы/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрожиточныеМинимумыВыбратьПоКоду: V82.СправочникиСсылка.ПрожиточныеМинимумы,IReturn<ПрожиточныеМинимумыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрожиточныеМинимумы/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ПрожиточныеМинимумы/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрожиточныеМинимумы/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрожиточныеМинимумыВыбратьПоНаименованию: V82.СправочникиСсылка.ПрожиточныеМинимумы,IReturn<ПрожиточныеМинимумыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрожиточныеМинимумы/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПрожиточныеМинимумыСтраницаПоСсылке: V82.СправочникиСсылка.ПрожиточныеМинимумы,IReturn<ПрожиточныеМинимумыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПрожиточныеМинимумы/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ПрожиточныеМинимумыСтраницаПоКоду: V82.СправочникиСсылка.ПрожиточныеМинимумы,IReturn<ПрожиточныеМинимумыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПрожиточныеМинимумы/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ПрожиточныеМинимумыСтраницаПоНаименованию: V82.СправочникиСсылка.ПрожиточныеМинимумы,IReturn<ПрожиточныеМинимумыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПрожиточныеМинимумыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПрожиточныеМинимумыСервис : Service
	{
		
		public object Get(ПрожиточныеМинимумыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПрожиточныеМинимумыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПрожиточныеМинимумыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ПрожиточныеМинимумы.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ПрожиточныеМинимумыОтвет() {Ответ = "ПрожиточныеМинимумы c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПрожиточныеМинимумыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПрожиточныеМинимумыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ПрожиточныеМинимумы.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПрожиточныеМинимумыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПрожиточныеМинимумыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПрожиточныеМинимумыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПрожиточныеМинимумыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПрожиточныеМинимумыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ПрожиточныеМинимумыЗапрос Запрос)
		{
			return new ПрожиточныеМинимумыОтвет {Ответ = "ПрожиточныеМинимумы, "};
		}

		public object Post(ПрожиточныеМинимумыЗапрос ЗапросПрожиточныеМинимумы)
		{
			var Ссылка = (СправочникиСсылка.ПрожиточныеМинимумы)ЗапросПрожиточныеМинимумы;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}