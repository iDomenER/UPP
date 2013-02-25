﻿
using System;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	[ProtoContract]
	[DataContract]
	public partial class НастройкиОбменаДанными:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("974e44aa-e7aa-46dd-9ff5-b3aff627f21f");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191715.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления {get;set;}
		public bool Предопределенный {get;set;}
		public string/*3*/ Код {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*150*/ Наименование {get;set;}
		public ПланОбменаСсылка УзелИнформационнойБазы {get;set;}//Узел информационной базы
		public V82.Перечисления/*Ссылка*/.ТипыАвтоматическогоОбменаДанными ТипНастройки {get;set;}//Тип настройки
		public bool ПроизводитьПриемСообщений {get;set;}//Производить прием сообщений
		public bool ПроизводитьОтправкуСообщений {get;set;}//Производить отправку сообщений
		public decimal/*(10)*/ КоличествоЭлементовВТранзакцииНаВыгрузкуДанных {get;set;}//Количество элементов в транзакции на выгрузку данных
		public decimal/*(10)*/ КоличествоЭлементовВТранзакцииНаЗагрузкуДанных {get;set;}//Количество элементов в транзакции на загрузку данных
		public bool ВыполнятьАрхивациюФайловОбмена {get;set;}//Выполнять архивацию файлов обмена
		public string/*(0)*/ ПарольНаОтправку {get;set;}//Пароль на отправку
		public string/*(0)*/ ПарольНаПрием {get;set;}//Пароль на прием
		public string/*(0)*/ КаталогОбменаИнформацией {get;set;}//Каталог обмена информацией
		public string/*(0)*/ FTPАдресОбмена {get;set;}//FTP адрес обмена
		public decimal/*(10)*/ ПортFTPСоединения {get;set;}//Порт FTP соединения
		public string/*(50)*/ ПользовательFTPСоединения {get;set;}//Пользователь FTP соединения
		public string/*(50)*/ ПарольFTPСоединения {get;set;}//Пароль FTP соединения
		public string/*(0)*/ Комментарий {get;set;}
		public decimal/*(10)*/ МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP {get;set;}//Максимальный размер отправляемого получаемого пакета через FTP
		public bool ПассивноеFTPСоединение {get;set;}//Пассивное FTPСоединение
		public string/*(0)*/ ПочтовыйАдресПолучателя {get;set;}//Почтовый адрес получателя
		public V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты УчетнаяЗаписьПриемаОтправкиСообщений {get;set;}//Учетная запись приема отправки сообщений
		public bool АвтоматическиЗакачиватьПочтуПриОбмене {get;set;}//Автоматически закачивать почту при обмене
		public decimal/*(10)*/ МаксимальныйРазмерОтправляемогоПакетаЧерезПочту {get;set;}//Максимальный размер отправляемого пакета через почту
		public ПланОбменаСсылка УзелФоновогоОбмена {get;set;}//Узел фонового обмена
		public ХранилищеЗначения ПравилаОбмена {get;set;}//Правила обмена
		public ХранилищеЗначения ПравилаОбменаДляПриемника {get;set;}//Правила обмена для приемника
		public decimal/*(10)*/ ДобавлениеОбъектовИзФоновогоОбмена {get;set;}//Добавление объектов из фонового обмена
		public decimal/*(10)*/ КоличествоОбъектовДляФоновогоОбмена {get;set;}//Количество объектов для фонового обмена
		public bool OnLineОбмен {get;set;}//On line обмен
		public bool ТипИнформационнойБазыДляПодключения {get;set;}//Тип информационной базы для подключения
		public string/*(0)*/ КаталогИнформационнойБазыДляПодключения {get;set;}//Каталог информационной базы для подключения
		public string/*(0)*/ ИмяСервераИнформационнойБазыДляПодключения {get;set;}//Имя сервера информационной базы для подключения
		public string/*(0)*/ ИмяИнформационнойБазыНаСервереДляПодключения {get;set;}//Имя информационной базы на сервере для подключения
		public bool АутентификацияWindowsИнформационнойБазыДляПодключения {get;set;}//Аутентификация windows информационной базы для подключения
		public string/*(0)*/ ПользовательИнформационнойБазыДляПодключения {get;set;}//Пользователь информационной базы для подключения
		public string/*(0)*/ ПарольИнформационнойБазыДляПодключения {get;set;}//Пароль информационной базы для подключения
		public string/*(5)*/ ВерсияПлатформыИнформационнойБазыДляПодключения {get;set;}//Версия платформы информационной базы для подключения
		public bool РежимОтладкиOnLineОбмена {get;set;}//Режим отладки on line обмена
		public string/*(255)*/ ИмяФайлаПротоколаОбменаOnLineОбмен {get;set;}//Имя файла протокола обмена on line обмен
		public ПланОбменаСсылка ТипУзлаИнформационнойБазы {get;set;}//Тип узла информационной базы
		public V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты УчетнаяЗаписьОтправкиСообщенияОбОшибке {get;set;}//Учетная запись отправки сообщения об ошибке
		public string/*(100)*/ АдресДляОтправкиСообщенийОбОшибке {get;set;}//Адрес для отправки сообщений об ошибке
		public bool ПослеОшибкиОтложенногоПроведенияПрекратитьОперации {get;set;}//После ошибки отложенного проведения прекратить операции
		public decimal/*(10)*/ КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации {get;set;}//Количество ошибок отложенного проведения для прекращения операции
		public bool ВыполнятьДействияПодПолнымиПравами {get;set;}//Выполнять действия под полными правами
		public bool ПроизводитьОтправкуТолькоПриУспешномПриеме {get;set;}//Производить отправку только при успешном приеме
		public bool ВыполнитьОтложенноеПроведениеДокументовПоРасписанию {get;set;}//Выполнить отложенное проведение документов по расписанию
		public string/*(50)*/ ПользовательПроксиFTP {get;set;}//Пользователь прокси FTP
		public string/*(50)*/ ПарольПроксиFTP {get;set;}//Пароль прокси FTP
		public string/*(50)*/ СерверПроксиFTP {get;set;}//Сервер прокси FTP
		public decimal/*(10)*/ ПортПроксиFTP {get;set;}//Порт прокси FTP
		public string/*(50)*/ ПротоколПроксиFTP {get;set;}//Протокол прокси FTP
		
		public НастройкиОбменаДанными()
		{
		}
		
		public НастройкиОбменаДанными(byte[] УникальныйИдентификатор)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2713_TYPE [УзелИнформационнойБазы_Тип],_Fld2713_RRRef [УзелИнформационнойБазы],_Fld2713_RTRef [УзелИнформационнойБазы_Вид]
					,_Fld2714RRef [ТипНастройки]
					,_Fld2715 [ПроизводитьПриемСообщений]
					,_Fld2716 [ПроизводитьОтправкуСообщений]
					,_Fld2717 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld2718 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld2719 [ВыполнятьАрхивациюФайловОбмена]
					,_Fld2720 [ПарольНаОтправку]
					,_Fld2721 [ПарольНаПрием]
					,_Fld2722 [КаталогОбменаИнформацией]
					,_Fld2723 [FTPАдресОбмена]
					,_Fld2724 [ПортFTPСоединения]
					,_Fld2725 [ПользовательFTPСоединения]
					,_Fld2726 [ПарольFTPСоединения]
					,_Fld2727 [Комментарий]
					,_Fld2728 [МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP]
					,_Fld2729 [ПассивноеFTPСоединение]
					,_Fld2730 [ПочтовыйАдресПолучателя]
					,_Fld2731RRef [УчетнаяЗаписьПриемаОтправкиСообщений]
					,_Fld2732 [АвтоматическиЗакачиватьПочтуПриОбмене]
					,_Fld2733 [МаксимальныйРазмерОтправляемогоПакетаЧерезПочту]
					,_Fld2734_TYPE [УзелФоновогоОбмена_Тип],_Fld2734_RRRef [УзелФоновогоОбмена],_Fld2734_RTRef [УзелФоновогоОбмена_Вид]
					,_Fld2735 [ПравилаОбмена]
					,_Fld2736 [ПравилаОбменаДляПриемника]
					,_Fld2737 [ДобавлениеОбъектовИзФоновогоОбмена]
					,_Fld2738 [КоличествоОбъектовДляФоновогоОбмена]
					,_Fld2739 [OnLineОбмен]
					,_Fld2740 [ТипИнформационнойБазыДляПодключения]
					,_Fld2741 [КаталогИнформационнойБазыДляПодключения]
					,_Fld2742 [ИмяСервераИнформационнойБазыДляПодключения]
					,_Fld2743 [ИмяИнформационнойБазыНаСервереДляПодключения]
					,_Fld2744 [АутентификацияWindowsИнформационнойБазыДляПодключения]
					,_Fld2745 [ПользовательИнформационнойБазыДляПодключения]
					,_Fld2746 [ПарольИнформационнойБазыДляПодключения]
					,_Fld2747 [ВерсияПлатформыИнформационнойБазыДляПодключения]
					,_Fld2748 [РежимОтладкиOnLineОбмена]
					,_Fld2749 [ИмяФайлаПротоколаОбменаOnLineОбмен]
					,_Fld2750_TYPE [ТипУзлаИнформационнойБазы_Тип],_Fld2750_RRRef [ТипУзлаИнформационнойБазы],_Fld2750_RTRef [ТипУзлаИнформационнойБазы_Вид]
					,_Fld2751RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld2752 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld2753 [ПослеОшибкиОтложенногоПроведенияПрекратитьОперации]
					,_Fld2754 [КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации]
					,_Fld2755 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld2756 [ПроизводитьОтправкуТолькоПриУспешномПриеме]
					,_Fld2757 [ВыполнитьОтложенноеПроведениеДокументовПоРасписанию]
					,_Fld2758 [ПользовательПроксиFTP]
					,_Fld2759 [ПарольПроксиFTP]
					,_Fld2760 [СерверПроксиFTP]
					,_Fld2761 [ПортПроксиFTP]
					,_Fld2762 [ПротоколПроксиFTP]
					From _Reference153(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор";
					Команда.Parameters.AddWithValue("УникальныйИдентификатор", УникальныйИдентификатор);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							//ToDo: Читать нужно через GetValues()
							Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Код = Читалка.GetString(4);
							Наименование = Читалка.GetString(5);
							ТипНастройки = V82.Перечисления/*Ссылка*/.ТипыАвтоматическогоОбменаДанными.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							ПроизводитьПриемСообщений = ((byte[])Читалка.GetValue(10))[0]==1;
							ПроизводитьОтправкуСообщений = ((byte[])Читалка.GetValue(11))[0]==1;
							КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(12);
							КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(13);
							ВыполнятьАрхивациюФайловОбмена = ((byte[])Читалка.GetValue(14))[0]==1;
							ПарольНаОтправку = Читалка.GetString(15);
							ПарольНаПрием = Читалка.GetString(16);
							КаталогОбменаИнформацией = Читалка.GetString(17);
							FTPАдресОбмена = Читалка.GetString(18);
							ПортFTPСоединения = Читалка.GetDecimal(19);
							ПользовательFTPСоединения = Читалка.GetString(20);
							ПарольFTPСоединения = Читалка.GetString(21);
							Комментарий = Читалка.GetString(22);
							МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP = Читалка.GetDecimal(23);
							ПассивноеFTPСоединение = ((byte[])Читалка.GetValue(24))[0]==1;
							ПочтовыйАдресПолучателя = Читалка.GetString(25);
							УчетнаяЗаписьПриемаОтправкиСообщений = new V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты((byte[])Читалка.GetValue(26));
							АвтоматическиЗакачиватьПочтуПриОбмене = ((byte[])Читалка.GetValue(27))[0]==1;
							МаксимальныйРазмерОтправляемогоПакетаЧерезПочту = Читалка.GetDecimal(28);
							ДобавлениеОбъектовИзФоновогоОбмена = Читалка.GetDecimal(34);
							КоличествоОбъектовДляФоновогоОбмена = Читалка.GetDecimal(35);
							OnLineОбмен = ((byte[])Читалка.GetValue(36))[0]==1;
							ТипИнформационнойБазыДляПодключения = ((byte[])Читалка.GetValue(37))[0]==1;
							КаталогИнформационнойБазыДляПодключения = Читалка.GetString(38);
							ИмяСервераИнформационнойБазыДляПодключения = Читалка.GetString(39);
							ИмяИнформационнойБазыНаСервереДляПодключения = Читалка.GetString(40);
							АутентификацияWindowsИнформационнойБазыДляПодключения = ((byte[])Читалка.GetValue(41))[0]==1;
							ПользовательИнформационнойБазыДляПодключения = Читалка.GetString(42);
							ПарольИнформационнойБазыДляПодключения = Читалка.GetString(43);
							ВерсияПлатформыИнформационнойБазыДляПодключения = Читалка.GetString(44);
							РежимОтладкиOnLineОбмена = ((byte[])Читалка.GetValue(45))[0]==1;
							ИмяФайлаПротоколаОбменаOnLineОбмен = Читалка.GetString(46);
							УчетнаяЗаписьОтправкиСообщенияОбОшибке = new V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты((byte[])Читалка.GetValue(50));
							АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(51);
							ПослеОшибкиОтложенногоПроведенияПрекратитьОперации = ((byte[])Читалка.GetValue(52))[0]==1;
							КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации = Читалка.GetDecimal(53);
							ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(54))[0]==1;
							ПроизводитьОтправкуТолькоПриУспешномПриеме = ((byte[])Читалка.GetValue(55))[0]==1;
							ВыполнитьОтложенноеПроведениеДокументовПоРасписанию = ((byte[])Читалка.GetValue(56))[0]==1;
							ПользовательПроксиFTP = Читалка.GetString(57);
							ПарольПроксиFTP = Читалка.GetString(58);
							СерверПроксиFTP = Читалка.GetString(59);
							ПортПроксиFTP = Читалка.GetDecimal(60);
							ПротоколПроксиFTP = Читалка.GetString(61);
							//return Ссылка;
						}
						else
						{
							//return null;
						}
					}
				}
			}
		}
		
		public V82.СправочникиОбъект.НастройкиОбменаДанными  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиОбменаДанными();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.УзелИнформационнойБазы = УзелИнформационнойБазы;
			Объект.ТипНастройки = ТипНастройки;
			Объект.ПроизводитьПриемСообщений = ПроизводитьПриемСообщений;
			Объект.ПроизводитьОтправкуСообщений = ПроизводитьОтправкуСообщений;
			Объект.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = КоличествоЭлементовВТранзакцииНаВыгрузкуДанных;
			Объект.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = КоличествоЭлементовВТранзакцииНаЗагрузкуДанных;
			Объект.ВыполнятьАрхивациюФайловОбмена = ВыполнятьАрхивациюФайловОбмена;
			Объект.ПарольНаОтправку = ПарольНаОтправку;
			Объект.ПарольНаПрием = ПарольНаПрием;
			Объект.КаталогОбменаИнформацией = КаталогОбменаИнформацией;
			Объект.FTPАдресОбмена = FTPАдресОбмена;
			Объект.ПортFTPСоединения = ПортFTPСоединения;
			Объект.ПользовательFTPСоединения = ПользовательFTPСоединения;
			Объект.ПарольFTPСоединения = ПарольFTPСоединения;
			Объект.Комментарий = Комментарий;
			Объект.МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP = МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP;
			Объект.ПассивноеFTPСоединение = ПассивноеFTPСоединение;
			Объект.ПочтовыйАдресПолучателя = ПочтовыйАдресПолучателя;
			Объект.УчетнаяЗаписьПриемаОтправкиСообщений = УчетнаяЗаписьПриемаОтправкиСообщений;
			Объект.АвтоматическиЗакачиватьПочтуПриОбмене = АвтоматическиЗакачиватьПочтуПриОбмене;
			Объект.МаксимальныйРазмерОтправляемогоПакетаЧерезПочту = МаксимальныйРазмерОтправляемогоПакетаЧерезПочту;
			Объект.УзелФоновогоОбмена = УзелФоновогоОбмена;
			Объект.ПравилаОбмена = ПравилаОбмена;
			Объект.ПравилаОбменаДляПриемника = ПравилаОбменаДляПриемника;
			Объект.ДобавлениеОбъектовИзФоновогоОбмена = ДобавлениеОбъектовИзФоновогоОбмена;
			Объект.КоличествоОбъектовДляФоновогоОбмена = КоличествоОбъектовДляФоновогоОбмена;
			Объект.OnLineОбмен = OnLineОбмен;
			Объект.ТипИнформационнойБазыДляПодключения = ТипИнформационнойБазыДляПодключения;
			Объект.КаталогИнформационнойБазыДляПодключения = КаталогИнформационнойБазыДляПодключения;
			Объект.ИмяСервераИнформационнойБазыДляПодключения = ИмяСервераИнформационнойБазыДляПодключения;
			Объект.ИмяИнформационнойБазыНаСервереДляПодключения = ИмяИнформационнойБазыНаСервереДляПодключения;
			Объект.АутентификацияWindowsИнформационнойБазыДляПодключения = АутентификацияWindowsИнформационнойБазыДляПодключения;
			Объект.ПользовательИнформационнойБазыДляПодключения = ПользовательИнформационнойБазыДляПодключения;
			Объект.ПарольИнформационнойБазыДляПодключения = ПарольИнформационнойБазыДляПодключения;
			Объект.ВерсияПлатформыИнформационнойБазыДляПодключения = ВерсияПлатформыИнформационнойБазыДляПодключения;
			Объект.РежимОтладкиOnLineОбмена = РежимОтладкиOnLineОбмена;
			Объект.ИмяФайлаПротоколаОбменаOnLineОбмен = ИмяФайлаПротоколаОбменаOnLineОбмен;
			Объект.ТипУзлаИнформационнойБазы = ТипУзлаИнформационнойБазы;
			Объект.УчетнаяЗаписьОтправкиСообщенияОбОшибке = УчетнаяЗаписьОтправкиСообщенияОбОшибке;
			Объект.АдресДляОтправкиСообщенийОбОшибке = АдресДляОтправкиСообщенийОбОшибке;
			Объект.ПослеОшибкиОтложенногоПроведенияПрекратитьОперации = ПослеОшибкиОтложенногоПроведенияПрекратитьОперации;
			Объект.КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации = КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации;
			Объект.ВыполнятьДействияПодПолнымиПравами = ВыполнятьДействияПодПолнымиПравами;
			Объект.ПроизводитьОтправкуТолькоПриУспешномПриеме = ПроизводитьОтправкуТолькоПриУспешномПриеме;
			Объект.ВыполнитьОтложенноеПроведениеДокументовПоРасписанию = ВыполнитьОтложенноеПроведениеДокументовПоРасписанию;
			Объект.ПользовательПроксиFTP = ПользовательПроксиFTP;
			Объект.ПарольПроксиFTP = ПарольПроксиFTP;
			Объект.СерверПроксиFTP = СерверПроксиFTP;
			Объект.ПортПроксиFTP = ПортПроксиFTP;
			Объект.ПротоколПроксиFTP = ПротоколПроксиFTP;
			return Объект;
		}
		
		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}
		
		public string СериализацияJson()
		{
			return this.ToJson();
		}
		
		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}