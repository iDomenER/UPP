﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//UsloviyaProdazh
	[Маршрут("Справочники/УсловияПродаж","")]
	public class УсловияПродажЗапрос: V82.СправочникиСсылка.УсловияПродаж,IReturn<УсловияПродажЗапрос>
	{
	}
	[Маршрут("Справочники/УсловияПродаж/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/УсловияПродаж/ПоСсылке","{Ссылка}")]
	public class УсловияПродажНайтиПоСсылке: V82.СправочникиСсылка.УсловияПродаж,IReturn<УсловияПродажНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/УсловияПродаж/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/УсловияПродаж/ПоКоду","{Код}")]
	public class УсловияПродажНайтиПоКоду: V82.СправочникиСсылка.УсловияПродаж,IReturn<УсловияПродажНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/УсловияПродаж/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/УсловияПродаж/ПоНаименованию","{Наименование}")]
	public class УсловияПродажНайтиПоНаименованию: V82.СправочникиСсылка.УсловияПродаж,IReturn<УсловияПродажНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/УсловияПродаж/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/УсловияПродаж/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/УсловияПродаж/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class УсловияПродажВыбратьПоСсылке: V82.СправочникиСсылка.УсловияПродаж,IReturn<УсловияПродажВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/УсловияПродаж/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/УсловияПродаж/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/УсловияПродаж/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class УсловияПродажВыбратьПоКоду: V82.СправочникиСсылка.УсловияПродаж,IReturn<УсловияПродажВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/УсловияПродаж/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/УсловияПродаж/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/УсловияПродаж/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class УсловияПродажВыбратьПоНаименованию: V82.СправочникиСсылка.УсловияПродаж,IReturn<УсловияПродажВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/УсловияПродаж/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class УсловияПродажСтраницаПоСсылке: V82.СправочникиСсылка.УсловияПродаж,IReturn<УсловияПродажСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/УсловияПродаж/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class УсловияПродажСтраницаПоКоду: V82.СправочникиСсылка.УсловияПродаж,IReturn<УсловияПродажСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/УсловияПродаж/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class УсловияПродажСтраницаПоНаименованию: V82.СправочникиСсылка.УсловияПродаж,IReturn<УсловияПродажСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class УсловияПродажОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class УсловияПродажСервис : Service
	{
		
		public object Get(УсловияПродажЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(УсловияПродажНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(УсловияПродажНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.УсловияПродаж.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new УсловияПродажОтвет() {Ответ = "УсловияПродаж c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(УсловияПродажНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(УсловияПродажВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.УсловияПродаж.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(УсловияПродажВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(УсловияПродажВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(УсловияПродажСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(УсловияПродажСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(УсловияПродажСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(УсловияПродажЗапрос Запрос)
		{
			return new УсловияПродажОтвет {Ответ = "УсловияПродаж, "};
		}

		public object Post(УсловияПродажЗапрос ЗапросУсловияПродаж)
		{
			var Ссылка = (СправочникиСсылка.УсловияПродаж)ЗапросУсловияПродаж;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}