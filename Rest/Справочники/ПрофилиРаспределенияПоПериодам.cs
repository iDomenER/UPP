﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//ProfiliRaspredeleniyaPoPeriodam
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам","")]
	public class ПрофилиРаспределенияПоПериодамЗапрос: V82.СправочникиСсылка.ПрофилиРаспределенияПоПериодам,IReturn<ПрофилиРаспределенияПоПериодамЗапрос>
	{
	}
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ПоСсылке","{Ссылка}")]
	public class ПрофилиРаспределенияПоПериодамНайтиПоСсылке: V82.СправочникиСсылка.ПрофилиРаспределенияПоПериодам,IReturn<ПрофилиРаспределенияПоПериодамНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ПоКоду","{Код}")]
	public class ПрофилиРаспределенияПоПериодамНайтиПоКоду: V82.СправочникиСсылка.ПрофилиРаспределенияПоПериодам,IReturn<ПрофилиРаспределенияПоПериодамНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ПоНаименованию","{Наименование}")]
	public class ПрофилиРаспределенияПоПериодамНайтиПоНаименованию: V82.СправочникиСсылка.ПрофилиРаспределенияПоПериодам,IReturn<ПрофилиРаспределенияПоПериодамНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрофилиРаспределенияПоПериодамВыбратьПоСсылке: V82.СправочникиСсылка.ПрофилиРаспределенияПоПериодам,IReturn<ПрофилиРаспределенияПоПериодамВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрофилиРаспределенияПоПериодамВыбратьПоКоду: V82.СправочникиСсылка.ПрофилиРаспределенияПоПериодам,IReturn<ПрофилиРаспределенияПоПериодамВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрофилиРаспределенияПоПериодамВыбратьПоНаименованию: V82.СправочникиСсылка.ПрофилиРаспределенияПоПериодам,IReturn<ПрофилиРаспределенияПоПериодамВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПрофилиРаспределенияПоПериодамСтраницаПоСсылке: V82.СправочникиСсылка.ПрофилиРаспределенияПоПериодам,IReturn<ПрофилиРаспределенияПоПериодамСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ПрофилиРаспределенияПоПериодамСтраницаПоКоду: V82.СправочникиСсылка.ПрофилиРаспределенияПоПериодам,IReturn<ПрофилиРаспределенияПоПериодамСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПрофилиРаспределенияПоПериодам/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ПрофилиРаспределенияПоПериодамСтраницаПоНаименованию: V82.СправочникиСсылка.ПрофилиРаспределенияПоПериодам,IReturn<ПрофилиРаспределенияПоПериодамСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПрофилиРаспределенияПоПериодамОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПрофилиРаспределенияПоПериодамСервис : Service
	{
		
		public object Get(ПрофилиРаспределенияПоПериодамЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиРаспределенияПоПериодамНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиРаспределенияПоПериодамНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ПрофилиРаспределенияПоПериодам.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ПрофилиРаспределенияПоПериодамОтвет() {Ответ = "ПрофилиРаспределенияПоПериодам c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПрофилиРаспределенияПоПериодамНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиРаспределенияПоПериодамВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ПрофилиРаспределенияПоПериодам.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПрофилиРаспределенияПоПериодамВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиРаспределенияПоПериодамВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиРаспределенияПоПериодамСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиРаспределенияПоПериодамСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиРаспределенияПоПериодамСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ПрофилиРаспределенияПоПериодамЗапрос Запрос)
		{
			return new ПрофилиРаспределенияПоПериодамОтвет {Ответ = "ПрофилиРаспределенияПоПериодам, "};
		}

		public object Post(ПрофилиРаспределенияПоПериодамЗапрос ЗапросПрофилиРаспределенияПоПериодам)
		{
			var Ссылка = (СправочникиСсылка.ПрофилиРаспределенияПоПериодам)ЗапросПрофилиРаспределенияПоПериодам;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}