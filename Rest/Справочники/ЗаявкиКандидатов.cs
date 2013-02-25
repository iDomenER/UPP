﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//ZayavkiKandidatov
	[Маршрут("Справочники/ЗаявкиКандидатов","")]
	public class ЗаявкиКандидатовЗапрос: V82.СправочникиСсылка.ЗаявкиКандидатов,IReturn<ЗаявкиКандидатовЗапрос>
	{
	}
	[Маршрут("Справочники/ЗаявкиКандидатов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ЗаявкиКандидатов/ПоСсылке","{Ссылка}")]
	public class ЗаявкиКандидатовНайтиПоСсылке: V82.СправочникиСсылка.ЗаявкиКандидатов,IReturn<ЗаявкиКандидатовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ЗаявкиКандидатов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ЗаявкиКандидатов/ПоКоду","{Код}")]
	public class ЗаявкиКандидатовНайтиПоКоду: V82.СправочникиСсылка.ЗаявкиКандидатов,IReturn<ЗаявкиКандидатовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ЗаявкиКандидатов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ЗаявкиКандидатов/ПоНаименованию","{Наименование}")]
	public class ЗаявкиКандидатовНайтиПоНаименованию: V82.СправочникиСсылка.ЗаявкиКандидатов,IReturn<ЗаявкиКандидатовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ЗаявкиКандидатов/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ЗаявкиКандидатов/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЗаявкиКандидатов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ЗаявкиКандидатовВыбратьПоСсылке: V82.СправочникиСсылка.ЗаявкиКандидатов,IReturn<ЗаявкиКандидатовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЗаявкиКандидатов/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ЗаявкиКандидатов/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЗаявкиКандидатов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ЗаявкиКандидатовВыбратьПоКоду: V82.СправочникиСсылка.ЗаявкиКандидатов,IReturn<ЗаявкиКандидатовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЗаявкиКандидатов/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ЗаявкиКандидатов/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЗаявкиКандидатов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ЗаявкиКандидатовВыбратьПоНаименованию: V82.СправочникиСсылка.ЗаявкиКандидатов,IReturn<ЗаявкиКандидатовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЗаявкиКандидатов/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ЗаявкиКандидатовСтраницаПоСсылке: V82.СправочникиСсылка.ЗаявкиКандидатов,IReturn<ЗаявкиКандидатовСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ЗаявкиКандидатов/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ЗаявкиКандидатовСтраницаПоКоду: V82.СправочникиСсылка.ЗаявкиКандидатов,IReturn<ЗаявкиКандидатовСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ЗаявкиКандидатов/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ЗаявкиКандидатовСтраницаПоНаименованию: V82.СправочникиСсылка.ЗаявкиКандидатов,IReturn<ЗаявкиКандидатовСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ЗаявкиКандидатовОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ЗаявкиКандидатовСервис : Service
	{
		
		public object Get(ЗаявкиКандидатовЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ЗаявкиКандидатовНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ЗаявкиКандидатовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ЗаявкиКандидатов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ЗаявкиКандидатовОтвет() {Ответ = "ЗаявкиКандидатов c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ЗаявкиКандидатовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ЗаявкиКандидатовВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ЗаявкиКандидатов.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ЗаявкиКандидатовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ЗаявкиКандидатовВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ЗаявкиКандидатовСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ЗаявкиКандидатовСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ЗаявкиКандидатовСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ЗаявкиКандидатовЗапрос Запрос)
		{
			return new ЗаявкиКандидатовОтвет {Ответ = "ЗаявкиКандидатов, "};
		}

		public object Post(ЗаявкиКандидатовЗапрос ЗапросЗаявкиКандидатов)
		{
			var Ссылка = (СправочникиСсылка.ЗаявкиКандидатов)ЗапросЗаявкиКандидатов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}