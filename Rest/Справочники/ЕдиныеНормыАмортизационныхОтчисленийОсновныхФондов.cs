﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//EdinyeNormyAmortizacionnykhOtchislenijjOsnovnykhFondov
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов","")]
	public class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовЗапрос: V82.СправочникиСсылка.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов,IReturn<ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовЗапрос>
	{
	}
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ПоСсылке","{Ссылка}")]
	public class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовНайтиПоСсылке: V82.СправочникиСсылка.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов,IReturn<ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ПоКоду","{Код}")]
	public class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовНайтиПоКоду: V82.СправочникиСсылка.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов,IReturn<ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ПоНаименованию","{Наименование}")]
	public class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовНайтиПоНаименованию: V82.СправочникиСсылка.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов,IReturn<ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовВыбратьПоСсылке: V82.СправочникиСсылка.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов,IReturn<ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовВыбратьПоКоду: V82.СправочникиСсылка.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов,IReturn<ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public decimal ___Мин {get; set;}
		public decimal ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовВыбратьПоНаименованию: V82.СправочникиСсылка.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов,IReturn<ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовСтраницаПоСсылке: V82.СправочникиСсылка.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов,IReturn<ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовСтраницаПоКоду: V82.СправочникиСсылка.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов,IReturn<ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовСтраницаПоНаименованию: V82.СправочникиСсылка.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов,IReturn<ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовСервис : Service
	{
		
		public object Get(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = Запрос.Код;
			var Ссылка = V82.Справочники.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовОтвет() {Ответ = "ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовЗапрос Запрос)
		{
			return new ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовОтвет {Ответ = "ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов, "};
		}

		public object Post(ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондовЗапрос ЗапросЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов)
		{
			var Ссылка = (СправочникиСсылка.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов)ЗапросЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}