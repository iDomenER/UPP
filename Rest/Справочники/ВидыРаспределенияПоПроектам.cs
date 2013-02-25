﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VidyRaspredeleniyaPoProektam
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам","")]
	public class ВидыРаспределенияПоПроектамЗапрос: V82.СправочникиСсылка.ВидыРаспределенияПоПроектам,IReturn<ВидыРаспределенияПоПроектамЗапрос>
	{
	}
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ПоСсылке","{Ссылка}")]
	public class ВидыРаспределенияПоПроектамНайтиПоСсылке: V82.СправочникиСсылка.ВидыРаспределенияПоПроектам,IReturn<ВидыРаспределенияПоПроектамНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ПоКоду","{Код}")]
	public class ВидыРаспределенияПоПроектамНайтиПоКоду: V82.СправочникиСсылка.ВидыРаспределенияПоПроектам,IReturn<ВидыРаспределенияПоПроектамНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ПоНаименованию","{Наименование}")]
	public class ВидыРаспределенияПоПроектамНайтиПоНаименованию: V82.СправочникиСсылка.ВидыРаспределенияПоПроектам,IReturn<ВидыРаспределенияПоПроектамНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыРаспределенияПоПроектамВыбратьПоСсылке: V82.СправочникиСсылка.ВидыРаспределенияПоПроектам,IReturn<ВидыРаспределенияПоПроектамВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыРаспределенияПоПроектамВыбратьПоКоду: V82.СправочникиСсылка.ВидыРаспределенияПоПроектам,IReturn<ВидыРаспределенияПоПроектамВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыРаспределенияПоПроектамВыбратьПоНаименованию: V82.СправочникиСсылка.ВидыРаспределенияПоПроектам,IReturn<ВидыРаспределенияПоПроектамВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВидыРаспределенияПоПроектамСтраницаПоСсылке: V82.СправочникиСсылка.ВидыРаспределенияПоПроектам,IReturn<ВидыРаспределенияПоПроектамСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВидыРаспределенияПоПроектамСтраницаПоКоду: V82.СправочникиСсылка.ВидыРаспределенияПоПроектам,IReturn<ВидыРаспределенияПоПроектамСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыРаспределенияПоПроектам/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВидыРаспределенияПоПроектамСтраницаПоНаименованию: V82.СправочникиСсылка.ВидыРаспределенияПоПроектам,IReturn<ВидыРаспределенияПоПроектамСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВидыРаспределенияПоПроектамОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВидыРаспределенияПоПроектамСервис : Service
	{
		
		public object Get(ВидыРаспределенияПоПроектамЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВидыРаспределенияПоПроектамНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыРаспределенияПоПроектамНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВидыРаспределенияПоПроектам.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВидыРаспределенияПоПроектамОтвет() {Ответ = "ВидыРаспределенияПоПроектам c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВидыРаспределенияПоПроектамНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыРаспределенияПоПроектамВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ВидыРаспределенияПоПроектам.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВидыРаспределенияПоПроектамВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыРаспределенияПоПроектамВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыРаспределенияПоПроектамСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыРаспределенияПоПроектамСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыРаспределенияПоПроектамСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВидыРаспределенияПоПроектамЗапрос Запрос)
		{
			return new ВидыРаспределенияПоПроектамОтвет {Ответ = "ВидыРаспределенияПоПроектам, "};
		}

		public object Post(ВидыРаспределенияПоПроектамЗапрос ЗапросВидыРаспределенияПоПроектам)
		{
			var Ссылка = (СправочникиСсылка.ВидыРаспределенияПоПроектам)ЗапросВидыРаспределенияПоПроектам;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}