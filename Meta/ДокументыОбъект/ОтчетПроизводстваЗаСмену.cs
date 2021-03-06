﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Общ)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ОтчетПроизводстваЗаСмену:ДокументОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public DateTime Дата {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public DateTime ПрефиксНомера {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*11*/ Номер {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public bool Проведен {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public bool АвтораспределениеВозвратныхОтходов {get;set;}//Автоматически распределять возвратные отходы на продукцию
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public bool АвтораспределениеМатериалов {get;set;}//Автоматически распределять материалы на продукцию
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public bool АвтораспределениеПрочихЗатрат {get;set;}//Автоматически распределять прочие затраты на продукцию
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public bool АвтораспределениеТехнологическихОпераций {get;set;}//Автоматически распределять тех. операции на продукцию
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public bool ВводитьСтатьиЗатратПоСтрокам {get;set;}//Вводить статьи затрат по строкам
		[DataMember]
		[ProtoMember(14)]
		public V82.ДокументыСсылка.ЗаданиеНаПроизводство ЗаданиеНаПроизводство {get;set;}//Задание на производство
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public V82.СправочникиСсылка.Склады Склад {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public bool ОтражатьВБухгалтерскомУчете {get;set;}//Отражать в бухгалтерском учете
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации {get;set;}//Подразделение организации
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public bool ОтражатьВУправленческомУчете {get;set;}//Отражать в управленческом учете
		///<summary>
		///(Упр)
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public V82.СправочникиСсылка.Подразделения Подразделение {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(22)]
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(23)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(24)]
		public V82.СправочникиСсылка.СтатьиЗатрат СтатьяЗатрат {get;set;}//Статья затрат по умолчанию
		[DataMember]
		[ProtoMember(25)]
		public bool ИспользоватьВозвратныеОтходы {get;set;}//Использовать возвратные отходы
		[DataMember]
		[ProtoMember(26)]
		public bool ИспользоватьЗаданияНаПроизводство {get;set;}//Использовать задания на производство
		[DataMember]
		[ProtoMember(27)]
		public bool ИспользоватьЗаказы {get;set;}//Использовать заказы
		[DataMember]
		[ProtoMember(28)]
		public bool ИспользоватьЗаказыНаОбслуживаниеОС {get;set;}//Использовать заказы на обслуживание ОС
		[DataMember]
		[ProtoMember(29)]
		public bool ИспользоватьМатериалы {get;set;}//Использовать материалы
		[DataMember]
		[ProtoMember(30)]
		public bool ИспользоватьНаправленияВыпуска {get;set;}//Использовать направления выпуска
		[DataMember]
		[ProtoMember(31)]
		public bool ИспользоватьНаработку {get;set;}//Использовать наработку
		[DataMember]
		[ProtoMember(32)]
		public bool ИспользоватьПодразделенияНЗП {get;set;}//Использовать подразделения НЗП
		[DataMember]
		[ProtoMember(33)]
		public bool ИспользоватьПрочиеЗатраты {get;set;}//Использовать прочие затраты
		[DataMember]
		[ProtoMember(34)]
		public bool ИспользоватьТехнологическиеОперации {get;set;}//Использовать технологические операции
		[DataMember]
		[ProtoMember(35)]
		public bool РазрешитьПревышениеЛимита {get;set;}//Разрешить превышение лимита
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(36)]
		public V82.СправочникиСсылка.Склады СкладОтходов {get;set;}//Склад отходов
		[DataMember]
		[ProtoMember(37)]
		public bool ИспользоватьАналитикуНЗП {get;set;}//Использовать аналитику НЗП
		[DataMember]
		[ProtoMember(38)]
		public bool УчитыватьТариф {get;set;}//Учитывать тариф
		[DataMember]
		[ProtoMember(39)]
		public bool УчитыватьКТУ {get;set;}//Учитывать КТУ
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для Документов.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Document357(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld7463
						,_Fld7464
						,_Fld7465
						,_Fld7466
						,_Fld7467
						,_Fld7468RRef
						,_Fld7469
						,_Fld7470RRef
						,_Fld7477RRef
						,_Fld7472
						,_Fld7476RRef
						,_Fld7474
						,_Fld7475RRef
						,_Fld7473
						,_Fld7471RRef
						,_Fld7478RRef
						,_Fld7479
						,_Fld7480
						,_Fld7481
						,_Fld7482
						,_Fld7483
						,_Fld7484
						,_Fld7485
						,_Fld18997
						,_Fld7486
						,_Fld7487
						,_Fld7488
						,_Fld7489RRef
						,_Fld18998
						,_Fld21806
						,_Fld21807)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@АвтораспределениеВозвратныхОтходов
						,@АвтораспределениеМатериалов
						,@АвтораспределениеПрочихЗатрат
						,@АвтораспределениеТехнологическихОпераций
						,@ВводитьСтатьиЗатратПоСтрокам
						,@ЗаданиеНаПроизводство
						,@Комментарий
						,@Организация
						,@Склад
						,@ОтражатьВБухгалтерскомУчете
						,@ПодразделениеОрганизации
						,@ОтражатьВУправленческомУчете
						,@Подразделение
						,@ОтражатьВНалоговомУчете
						,@Ответственный
						,@СтатьяЗатрат
						,@ИспользоватьВозвратныеОтходы
						,@ИспользоватьЗаданияНаПроизводство
						,@ИспользоватьЗаказы
						,@ИспользоватьЗаказыНаОбслуживаниеОС
						,@ИспользоватьМатериалы
						,@ИспользоватьНаправленияВыпуска
						,@ИспользоватьНаработку
						,@ИспользоватьПодразделенияНЗП
						,@ИспользоватьПрочиеЗатраты
						,@ИспользоватьТехнологическиеОперации
						,@РазрешитьПревышениеЛимита
						,@СкладОтходов
						,@ИспользоватьАналитикуНЗП
						,@УчитыватьТариф
						,@УчитыватьКТУ)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document357
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld7463	= @АвтораспределениеВозвратныхОтходов
						,_Fld7464	= @АвтораспределениеМатериалов
						,_Fld7465	= @АвтораспределениеПрочихЗатрат
						,_Fld7466	= @АвтораспределениеТехнологическихОпераций
						,_Fld7467	= @ВводитьСтатьиЗатратПоСтрокам
						,_Fld7468RRef	= @ЗаданиеНаПроизводство
						,_Fld7469	= @Комментарий
						,_Fld7470RRef	= @Организация
						,_Fld7477RRef	= @Склад
						,_Fld7472	= @ОтражатьВБухгалтерскомУчете
						,_Fld7476RRef	= @ПодразделениеОрганизации
						,_Fld7474	= @ОтражатьВУправленческомУчете
						,_Fld7475RRef	= @Подразделение
						,_Fld7473	= @ОтражатьВНалоговомУчете
						,_Fld7471RRef	= @Ответственный
						,_Fld7478RRef	= @СтатьяЗатрат
						,_Fld7479	= @ИспользоватьВозвратныеОтходы
						,_Fld7480	= @ИспользоватьЗаданияНаПроизводство
						,_Fld7481	= @ИспользоватьЗаказы
						,_Fld7482	= @ИспользоватьЗаказыНаОбслуживаниеОС
						,_Fld7483	= @ИспользоватьМатериалы
						,_Fld7484	= @ИспользоватьНаправленияВыпуска
						,_Fld7485	= @ИспользоватьНаработку
						,_Fld18997	= @ИспользоватьПодразделенияНЗП
						,_Fld7486	= @ИспользоватьПрочиеЗатраты
						,_Fld7487	= @ИспользоватьТехнологическиеОперации
						,_Fld7488	= @РазрешитьПревышениеЛимита
						,_Fld7489RRef	= @СкладОтходов
						,_Fld18998	= @ИспользоватьАналитикуНЗП
						,_Fld21806	= @УчитыватьТариф
						,_Fld21807	= @УчитыватьКТУ
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("АвтораспределениеВозвратныхОтходов", АвтораспределениеВозвратныхОтходов);
					Команда.Parameters.AddWithValue("АвтораспределениеМатериалов", АвтораспределениеМатериалов);
					Команда.Parameters.AddWithValue("АвтораспределениеПрочихЗатрат", АвтораспределениеПрочихЗатрат);
					Команда.Parameters.AddWithValue("АвтораспределениеТехнологическихОпераций", АвтораспределениеТехнологическихОпераций);
					Команда.Parameters.AddWithValue("ВводитьСтатьиЗатратПоСтрокам", ВводитьСтатьиЗатратПоСтрокам);
					Команда.Parameters.AddWithValue("ЗаданиеНаПроизводство", ЗаданиеНаПроизводство.Ссылка);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("ОтражатьВБухгалтерскомУчете", ОтражатьВБухгалтерскомУчете);
					Команда.Parameters.AddWithValue("ОтражатьВУправленческомУчете", ОтражатьВУправленческомУчете);
					Команда.Parameters.AddWithValue("ОтражатьВНалоговомУчете", ОтражатьВНалоговомУчете);
					Команда.Parameters.AddWithValue("ИспользоватьВозвратныеОтходы", ИспользоватьВозвратныеОтходы);
					Команда.Parameters.AddWithValue("ИспользоватьЗаданияНаПроизводство", ИспользоватьЗаданияНаПроизводство);
					Команда.Parameters.AddWithValue("ИспользоватьЗаказы", ИспользоватьЗаказы);
					Команда.Parameters.AddWithValue("ИспользоватьЗаказыНаОбслуживаниеОС", ИспользоватьЗаказыНаОбслуживаниеОС);
					Команда.Parameters.AddWithValue("ИспользоватьМатериалы", ИспользоватьМатериалы);
					Команда.Parameters.AddWithValue("ИспользоватьНаправленияВыпуска", ИспользоватьНаправленияВыпуска);
					Команда.Parameters.AddWithValue("ИспользоватьНаработку", ИспользоватьНаработку);
					Команда.Parameters.AddWithValue("ИспользоватьПодразделенияНЗП", ИспользоватьПодразделенияНЗП);
					Команда.Parameters.AddWithValue("ИспользоватьПрочиеЗатраты", ИспользоватьПрочиеЗатраты);
					Команда.Parameters.AddWithValue("ИспользоватьТехнологическиеОперации", ИспользоватьТехнологическиеОперации);
					Команда.Parameters.AddWithValue("РазрешитьПревышениеЛимита", РазрешитьПревышениеЛимита);
					Команда.Parameters.AddWithValue("ИспользоватьАналитикуНЗП", ИспользоватьАналитикуНЗП);
					Команда.Parameters.AddWithValue("УчитыватьТариф", УчитыватьТариф);
					Команда.Parameters.AddWithValue("УчитыватьКТУ", УчитыватьКТУ);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Document357
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}