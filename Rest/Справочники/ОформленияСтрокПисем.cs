﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//OformleniyaStrokPisem
	[Маршрут("Справочники/ОформленияСтрокПисем","")]
	public class ОформленияСтрокПисемЗапрос: V82.СправочникиСсылка.ОформленияСтрокПисем,IReturn<ОформленияСтрокПисемЗапрос>
	{
	}
	[Маршрут("Справочники/ОформленияСтрокПисем/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОформленияСтрокПисем/ПоСсылке","{Ссылка}")]
	public class ОформленияСтрокПисемНайтиПоСсылке: V82.СправочникиСсылка.ОформленияСтрокПисем,IReturn<ОформленияСтрокПисемНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОформленияСтрокПисем/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ОформленияСтрокПисем/ПоКоду","{Код}")]
	public class ОформленияСтрокПисемНайтиПоКоду: V82.СправочникиСсылка.ОформленияСтрокПисем,IReturn<ОформленияСтрокПисемНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ОформленияСтрокПисем/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОформленияСтрокПисем/ПоНаименованию","{Наименование}")]
	public class ОформленияСтрокПисемНайтиПоНаименованию: V82.СправочникиСсылка.ОформленияСтрокПисем,IReturn<ОформленияСтрокПисемНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОформленияСтрокПисем/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ОформленияСтрокПисем/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОформленияСтрокПисем/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОформленияСтрокПисемВыбратьПоСсылке: V82.СправочникиСсылка.ОформленияСтрокПисем,IReturn<ОформленияСтрокПисемВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОформленияСтрокПисем/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ОформленияСтрокПисем/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОформленияСтрокПисем/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ОформленияСтрокПисемВыбратьПоКоду: V82.СправочникиСсылка.ОформленияСтрокПисем,IReturn<ОформленияСтрокПисемВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОформленияСтрокПисем/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ОформленияСтрокПисем/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОформленияСтрокПисем/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОформленияСтрокПисемВыбратьПоНаименованию: V82.СправочникиСсылка.ОформленияСтрокПисем,IReturn<ОформленияСтрокПисемВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОформленияСтрокПисем/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОформленияСтрокПисемСтраницаПоСсылке: V82.СправочникиСсылка.ОформленияСтрокПисем,IReturn<ОформленияСтрокПисемСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОформленияСтрокПисем/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ОформленияСтрокПисемСтраницаПоКоду: V82.СправочникиСсылка.ОформленияСтрокПисем,IReturn<ОформленияСтрокПисемСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОформленияСтрокПисем/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ОформленияСтрокПисемСтраницаПоНаименованию: V82.СправочникиСсылка.ОформленияСтрокПисем,IReturn<ОформленияСтрокПисемСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОформленияСтрокПисемОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОформленияСтрокПисемСервис : Service
	{
		
		public object Get(ОформленияСтрокПисемЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОформленияСтрокПисемНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОформленияСтрокПисемНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ОформленияСтрокПисем.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ОформленияСтрокПисемОтвет() {Ответ = "ОформленияСтрокПисем c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОформленияСтрокПисемНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОформленияСтрокПисемВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ОформленияСтрокПисем.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ОформленияСтрокПисемВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОформленияСтрокПисемВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОформленияСтрокПисемСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОформленияСтрокПисемСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОформленияСтрокПисемСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОформленияСтрокПисемЗапрос Запрос)
		{
			return new ОформленияСтрокПисемОтвет {Ответ = "ОформленияСтрокПисем, "};
		}

		public object Post(ОформленияСтрокПисемЗапрос ЗапросОформленияСтрокПисем)
		{
			var Ссылка = (СправочникиСсылка.ОформленияСтрокПисем)ЗапросОформленияСтрокПисем;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}