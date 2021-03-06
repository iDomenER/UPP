﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Polzovateli
	[Маршрут("Справочники/Пользователи","")]
	public class ПользователиЗапрос: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиЗапрос>
	{
	}
	[Маршрут("Справочники/Пользователи/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Пользователи/ПоСсылке","{Ссылка}")]
	public class ПользователиНайтиПоСсылке: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Пользователи/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Пользователи/ПоКоду","{Код}")]
	public class ПользователиНайтиПоКоду: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Пользователи/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Пользователи/ПоНаименованию","{Наименование}")]
	public class ПользователиНайтиПоНаименованию: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Пользователи/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Пользователи/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Пользователи/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПользователиВыбратьПоСсылке: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Пользователи/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/Пользователи/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Пользователи/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ПользователиВыбратьПоКоду: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Пользователи/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Пользователи/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Пользователи/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ПользователиВыбратьПоНаименованию: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Пользователи/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПользователиСтраницаПоСсылке: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Пользователи/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ПользователиСтраницаПоКоду: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Пользователи/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ПользователиСтраницаПоНаименованию: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Пользователи/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}")]
	[Маршрут("Справочники/Пользователи/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Пользователи/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}/{___Макс}")]
	public class ПользователиИерархияВыбратьПоСсылке: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиИерархияВыбратьПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Пользователи/ИерархияСтраницаПоСсылке","{___Родитель}/{___Режим}/{___Размер}/{___Номер}")]
	public class ПользователиИерархияСтраницаПоСсылке: V82.СправочникиСсылка.Пользователи,IReturn<ПользователиИерархияСтраницаПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПользователиОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПользователиСервис : Service
	{
		
		public object Get(ПользователиЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПользователиНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.Пользователи.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПользователиОтвет() { Ответ = "Пользователи c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПользователиНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Пользователи.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ПользователиОтвет() {Ответ = "Пользователи c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПользователиНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПользователиВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.Пользователи.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПользователиВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПользователиВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПользователиСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПользователиСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПользователиСтраницаПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПользователиИерархияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.Пользователи.ИерархияВыбратьПоСсылке(Запрос.___Родитель,Запрос.___Режим,Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПользователиИерархияСтраницаПоСсылке Запрос)
		{
			return null;
		}

		public object Any(ПользователиЗапрос Запрос)
		{
			return new ПользователиОтвет {Ответ = "Пользователи, "};
		}

		public object Post(ПользователиЗапрос ЗапросПользователи)
		{
			var Ссылка = (СправочникиСсылка.Пользователи)ЗапросПользователи;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}