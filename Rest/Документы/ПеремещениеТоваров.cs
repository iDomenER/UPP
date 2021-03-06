﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//PeremeshhenieTovarov
	[Маршрут("Документы/ПеремещениеТоваров","")]
	public class ПеремещениеТоваровЗапрос: V82.ДокументыСсылка.ПеремещениеТоваров,IReturn<ПеремещениеТоваровЗапрос>
	{
	}
	[Маршрут("Документы/ПеремещениеТоваров/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ПеремещениеТоваров/ПоСсылке","{Ссылка}")]
	public class ПеремещениеТоваровНайтиПоСсылке: V82.ДокументыСсылка.ПеремещениеТоваров,IReturn<ПеремещениеТоваровНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ПеремещениеТоваров/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ПеремещениеТоваров/ПоНомеру","{Номер}")]
	public class ПеремещениеТоваровНайтиПоНомеру: V82.ДокументыСсылка.ПеремещениеТоваров,IReturn<ПеремещениеТоваровНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ПеремещениеТоваров/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ПеремещениеТоваров/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПеремещениеТоваров/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПеремещениеТоваровВыбратьПоСсылке: V82.ДокументыСсылка.ПеремещениеТоваров,IReturn<ПеремещениеТоваровВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ПеремещениеТоваров/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ПеремещениеТоваров/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ПеремещениеТоваров/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ПеремещениеТоваровВыбратьПоНомеру: V82.ДокументыСсылка.ПеремещениеТоваров,IReturn<ПеремещениеТоваровВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ПеремещениеТоваров/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПеремещениеТоваровСтраницаПоСсылке: V82.ДокументыСсылка.ПеремещениеТоваров,IReturn<ПеремещениеТоваровСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ПеремещениеТоваров/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ПеремещениеТоваровСтраницаПоНомеру: V82.ДокументыСсылка.ПеремещениеТоваров,IReturn<ПеремещениеТоваровСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПеремещениеТоваровОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПеремещениеТоваровСервис : Service
	{
		
		public object Get(ПеремещениеТоваровЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПеремещениеТоваровНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ПеремещениеТоваров.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПеремещениеТоваровОтвет() { Ответ = "ПеремещениеТоваров c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПеремещениеТоваровНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ПеремещениеТоваров.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ПеремещениеТоваровОтвет() {Ответ = "ПеремещениеТоваров c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПеремещениеТоваровВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ПеремещениеТоваров.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПеремещениеТоваровВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ПеремещениеТоваровСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПеремещениеТоваровСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ПеремещениеТоваровЗапрос Запрос)
		{
			return new ПеремещениеТоваровОтвет {Ответ = "ПеремещениеТоваров, "};
		}

		public object Post(ПеремещениеТоваровЗапрос ЗапросПеремещениеТоваров)
		{
			var Ссылка = (ДокументыСсылка.ПеремещениеТоваров)ЗапросПеремещениеТоваров;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}