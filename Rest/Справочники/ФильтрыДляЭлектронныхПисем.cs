﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//FiltryDlyaEHlektronnykhPisem
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем","")]
	public class ФильтрыДляЭлектронныхПисемЗапрос: V82.СправочникиСсылка.ФильтрыДляЭлектронныхПисем,IReturn<ФильтрыДляЭлектронныхПисемЗапрос>
	{
	}
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ПоСсылке","{Ссылка}")]
	public class ФильтрыДляЭлектронныхПисемНайтиПоСсылке: V82.СправочникиСсылка.ФильтрыДляЭлектронныхПисем,IReturn<ФильтрыДляЭлектронныхПисемНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ПоКоду","{Код}")]
	public class ФильтрыДляЭлектронныхПисемНайтиПоКоду: V82.СправочникиСсылка.ФильтрыДляЭлектронныхПисем,IReturn<ФильтрыДляЭлектронныхПисемНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ПоНаименованию","{Наименование}")]
	public class ФильтрыДляЭлектронныхПисемНайтиПоНаименованию: V82.СправочникиСсылка.ФильтрыДляЭлектронныхПисем,IReturn<ФильтрыДляЭлектронныхПисемНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ФильтрыДляЭлектронныхПисемВыбратьПоСсылке: V82.СправочникиСсылка.ФильтрыДляЭлектронныхПисем,IReturn<ФильтрыДляЭлектронныхПисемВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ФильтрыДляЭлектронныхПисемВыбратьПоКоду: V82.СправочникиСсылка.ФильтрыДляЭлектронныхПисем,IReturn<ФильтрыДляЭлектронныхПисемВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ФильтрыДляЭлектронныхПисемВыбратьПоНаименованию: V82.СправочникиСсылка.ФильтрыДляЭлектронныхПисем,IReturn<ФильтрыДляЭлектронныхПисемВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ФильтрыДляЭлектронныхПисемСтраницаПоСсылке: V82.СправочникиСсылка.ФильтрыДляЭлектронныхПисем,IReturn<ФильтрыДляЭлектронныхПисемСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ФильтрыДляЭлектронныхПисемСтраницаПоКоду: V82.СправочникиСсылка.ФильтрыДляЭлектронныхПисем,IReturn<ФильтрыДляЭлектронныхПисемСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ФильтрыДляЭлектронныхПисем/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ФильтрыДляЭлектронныхПисемСтраницаПоНаименованию: V82.СправочникиСсылка.ФильтрыДляЭлектронныхПисем,IReturn<ФильтрыДляЭлектронныхПисемСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ФильтрыДляЭлектронныхПисемОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ФильтрыДляЭлектронныхПисемСервис : Service
	{
		
		public object Get(ФильтрыДляЭлектронныхПисемЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ФильтрыДляЭлектронныхПисемНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ФильтрыДляЭлектронныхПисемНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ФильтрыДляЭлектронныхПисем.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ФильтрыДляЭлектронныхПисемОтвет() {Ответ = "ФильтрыДляЭлектронныхПисем c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ФильтрыДляЭлектронныхПисемНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ФильтрыДляЭлектронныхПисемВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ФильтрыДляЭлектронныхПисем.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ФильтрыДляЭлектронныхПисемВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ФильтрыДляЭлектронныхПисемВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ФильтрыДляЭлектронныхПисемСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ФильтрыДляЭлектронныхПисемСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ФильтрыДляЭлектронныхПисемСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ФильтрыДляЭлектронныхПисемЗапрос Запрос)
		{
			return new ФильтрыДляЭлектронныхПисемОтвет {Ответ = "ФильтрыДляЭлектронныхПисем, "};
		}

		public object Post(ФильтрыДляЭлектронныхПисемЗапрос ЗапросФильтрыДляЭлектронныхПисем)
		{
			var Ссылка = (СправочникиСсылка.ФильтрыДляЭлектронныхПисем)ЗапросФильтрыДляЭлектронныхПисем;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}