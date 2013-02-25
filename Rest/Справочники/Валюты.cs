﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Valyuty
	[Маршрут("Справочники/Валюты","")]
	public class ВалютыЗапрос: V82.СправочникиСсылка.Валюты,IReturn<ВалютыЗапрос>
	{
	}
	[Маршрут("Справочники/Валюты/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Валюты/ПоСсылке","{Ссылка}")]
	public class ВалютыНайтиПоСсылке: V82.СправочникиСсылка.Валюты,IReturn<ВалютыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Валюты/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Валюты/ПоКоду","{Код}")]
	public class ВалютыНайтиПоКоду: V82.СправочникиСсылка.Валюты,IReturn<ВалютыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Валюты/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Валюты/ПоНаименованию","{Наименование}")]
	public class ВалютыНайтиПоНаименованию: V82.СправочникиСсылка.Валюты,IReturn<ВалютыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Валюты/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Валюты/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Валюты/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВалютыВыбратьПоСсылке: V82.СправочникиСсылка.Валюты,IReturn<ВалютыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Валюты/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/Валюты/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Валюты/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВалютыВыбратьПоКоду: V82.СправочникиСсылка.Валюты,IReturn<ВалютыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Валюты/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Валюты/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Валюты/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВалютыВыбратьПоНаименованию: V82.СправочникиСсылка.Валюты,IReturn<ВалютыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Валюты/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВалютыСтраницаПоСсылке: V82.СправочникиСсылка.Валюты,IReturn<ВалютыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Валюты/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВалютыСтраницаПоКоду: V82.СправочникиСсылка.Валюты,IReturn<ВалютыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Валюты/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВалютыСтраницаПоНаименованию: V82.СправочникиСсылка.Валюты,IReturn<ВалютыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВалютыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВалютыСервис : Service
	{
		
		public object Get(ВалютыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВалютыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВалютыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Валюты.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВалютыОтвет() {Ответ = "Валюты c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВалютыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВалютыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.Валюты.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВалютыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВалютыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВалютыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВалютыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВалютыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВалютыЗапрос Запрос)
		{
			return new ВалютыОтвет {Ответ = "Валюты, "};
		}

		public object Post(ВалютыЗапрос ЗапросВалюты)
		{
			var Ссылка = (СправочникиСсылка.Валюты)ЗапросВалюты;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}