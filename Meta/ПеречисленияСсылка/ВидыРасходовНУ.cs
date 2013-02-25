﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Регл)
	///</summary>
	[DataContract]
	public enum ВидыРасходовНУ
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"220010a4-f819-45fa-84da-c820bfa4cd64\", \"Представление\":\"ОплатаТруда\"}")]
		ОплатаТруда = 0,//Оплата труда
		[EnumMember(Value = "{\"Ссылка\":\"aff37a1f-575b-4bae-b2ad-d764aef14375\", \"Представление\":\"Амортизация\"}")]
		Амортизация = 1,
		[EnumMember(Value = "{\"Ссылка\":\"54e3a73e-94b2-4f30-86ad-aa7b1677a346\", \"Представление\":\"АрендаФедеральногоИМуниципальногоИмущества\"}")]
		АрендаФедеральногоИМуниципальногоИмущества = 2,//Аренда федерального и муниципального имущества
		[EnumMember(Value = "{\"Ссылка\":\"ce34658a-6d84-4fcf-8cec-dca658d39e5e\", \"Представление\":\"ДобровольноеЛичноеСтрахование\"}")]
		ДобровольноеЛичноеСтрахование = 3,//Добровольное личное страхование, предусматривающее оплату страховщиками медицинских расходов
		[EnumMember(Value = "{\"Ссылка\":\"94b7517b-c698-453b-85b4-9023cd44c65a\", \"Представление\":\"ДобровольноеЛичноеСтрахованиеНаСлучайСмертиИлиУтратыРаботоспособности\"}")]
		ДобровольноеЛичноеСтрахованиеНаСлучайСмертиИлиУтратыРаботоспособности = 4,//Договоры добровольного личного страхования, заключаемые исключительно на случай наступления смерти или утраты трудоспособности
		[EnumMember(Value = "{\"Ссылка\":\"d6fc52cd-2363-426a-b216-843193616393\", \"Представление\":\"ДобровольноеСтрахованиеПоДоговорамДолгосрочногоСтрахованияЖизниРаботников\"}")]
		ДобровольноеСтрахованиеПоДоговорамДолгосрочногоСтрахованияЖизниРаботников = 5,//Добровольное страхование по договорам долгосрочного страхования жизни работников, пенсионного страхования и (или) негосударственного пенсионного обеспечения работников
	///<summary>
	///Амортизационная премия (п. 1.1 ст. 259 НК РФ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"712a26a2-53dd-438e-a7d7-e9951fdbad9a\", \"Представление\":\"АмортизационнаяПремия\"}")]
		АмортизационнаяПремия = 6,//Амортизационная премия
		[EnumMember(Value = "{\"Ссылка\":\"db761c8f-140e-45e6-b899-313051317bb0\", \"Представление\":\"КомандировочныеРасходы\"}")]
		КомандировочныеРасходы = 7,//Командировочные расходы
		[EnumMember(Value = "{\"Ссылка\":\"f518a03a-610c-4304-bb9d-01d0a8810b58\", \"Представление\":\"МатериальныеРасходы\"}")]
		МатериальныеРасходы = 8,//Материальные расходы
		[EnumMember(Value = "{\"Ссылка\":\"a1a6b242-d948-4a91-9a84-0b03259251c2\", \"Представление\":\"УдалитьСтраховыеВзносы\"}")]
		УдалитьСтраховыеВзносы = 9,//Удалить страховые взносы
		[EnumMember(Value = "{\"Ссылка\":\"0ad2c61c-6cff-4c7e-9d9a-13fe028a5f84\", \"Представление\":\"СтраховыеВзносы\"}")]
		СтраховыеВзносы = 10,//Страховые взносы
		[EnumMember(Value = "{\"Ссылка\":\"4639d355-57bf-443e-8900-e2a5ff532c7c\", \"Представление\":\"НалогиИСборы\"}")]
		НалогиИСборы = 11,//Налоги и сборы
		[EnumMember(Value = "{\"Ссылка\":\"113f705a-5038-49c0-953e-bb53888e5abc\", \"Представление\":\"НИОКР\"}")]
		НИОКР = 12,
		[EnumMember(Value = "{\"Ссылка\":\"5afc2e52-8617-443c-ba9f-76cedf7370ac\", \"Представление\":\"НИОКРПоПеречнюПравительстваРФ\"}")]
		НИОКРПоПеречнюПравительстваРФ = 13,//НИОКР по перечню Правительства РФ
		[EnumMember(Value = "{\"Ссылка\":\"c074d7c1-eae4-4e16-a0f6-94a3682792ba\", \"Представление\":\"ОбязательноеИДобровольноеСтрахованиеИмущества\"}")]
		ОбязательноеИДобровольноеСтрахованиеИмущества = 14,//Обязательное и добровольное страхование имущества
		[EnumMember(Value = "{\"Ссылка\":\"f79afd23-4d40-4392-8750-b0932bffcea8\", \"Представление\":\"ПрочиеРасходы\"}")]
		ПрочиеРасходы = 15,//Прочие расходы
		[EnumMember(Value = "{\"Ссылка\":\"adcdc111-7175-4e3a-91f9-d570ded80d6f\", \"Представление\":\"ПредставительскиеРасходы\"}")]
		ПредставительскиеРасходы = 16,//Представительские расходы
		[EnumMember(Value = "{\"Ссылка\":\"02fa23ad-e21a-4f81-8be7-8c5be40568a6\", \"Представление\":\"РасходыНаРекламуНормируемые\"}")]
		РасходыНаРекламуНормируемые = 17,//Расходы на рекламу (нормируемые)
		[EnumMember(Value = "{\"Ссылка\":\"af8ab34b-84f7-466a-9c57-d8cb8f9d2cdb\", \"Представление\":\"РемонтОсновныхСредств\"}")]
		РемонтОсновныхСредств = 18,//Ремонт основных средств
		[EnumMember(Value = "{\"Ссылка\":\"70dd5007-17b3-45bc-ae74-8a2fc0cd9562\", \"Представление\":\"РасходыНаВозмещениеЗатратРаботниковПоУплатеПроцентов\"}")]
		РасходыНаВозмещениеЗатратРаботниковПоУплатеПроцентов = 19,//Расходы на возмещение затрат работников по уплате процентов
		[EnumMember(Value = "{\"Ссылка\":\"d14d1d70-41e5-4656-8002-4d31e4bed7e6\", \"Представление\":\"ОсвоениеПриродныхРесурсов\"}")]
		ОсвоениеПриродныхРесурсов = 20,//Освоение природных ресурсов
		[EnumMember(Value = "{\"Ссылка\":\"27be64a0-9712-4a8c-82dc-616c93d9d483\", \"Представление\":\"НеУчитываемыеВЦеляхНалогообложения\"}")]
		НеУчитываемыеВЦеляхНалогообложения = 21,//Не учитываемые в целях налогообложения
		[EnumMember(Value = "{\"Ссылка\":\"17bc7a24-7852-48f2-b8a8-2031d2d462ad\", \"Представление\":\"ЕСН\"}")]
		ЕСН = 22,
		[EnumMember(Value = "{\"Ссылка\":\"f123dae2-b47d-4475-873b-d01b21967d6a\", \"Представление\":\"ТранспортныеРасходы\"}")]
		ТранспортныеРасходы = 23,//Транспортные расходы
	}
	public static partial class ВидыРасходовНУ_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ОплатаТруда = new Guid("20c8da84-a4bf-64cd-45fa-f819220010a4");//Оплата труда
		public static readonly Guid Амортизация = new Guid("64d7adb2-f1ae-7543-4bae-575baff37a1f");
		public static readonly Guid АрендаФедеральногоИМуниципальногоИмущества = new Guid("7baaad86-7716-46a3-4f30-94b254e3a73e");//Аренда федерального и муниципального имущества
		public static readonly Guid ДобровольноеЛичноеСтрахование = new Guid("a6dcec8c-d358-5e9e-4fcf-6d84ce34658a");//Добровольное личное страхование, предусматривающее оплату страховщиками медицинских расходов
		public static readonly Guid ДобровольноеЛичноеСтрахованиеНаСлучайСмертиИлиУтратыРаботоспособности = new Guid("2390b485-44cd-5ac6-453b-c69894b7517b");//Договоры добровольного личного страхования, заключаемые исключительно на случай наступления смерти или утраты трудоспособности
		public static readonly Guid ДобровольноеСтрахованиеПоДоговорамДолгосрочногоСтрахованияЖизниРаботников = new Guid("318416b2-6193-9363-426a-2363d6fc52cd");//Добровольное страхование по договорам долгосрочного страхования жизни работников, пенсионного страхования и (или) негосударственного пенсионного обеспечения работников
		///<summary>
		///Амортизационная премия (п. 1.1 ст. 259 НК РФ)
		///</summary>
		public static readonly Guid АмортизационнаяПремия = new Guid("95e9d7a7-db1f-9aad-438e-53dd712a26a2");//Амортизационная премия
		public static readonly Guid КомандировочныеРасходы = new Guid("303199b8-3151-b07b-45e6-140edb761c8f");//Командировочные расходы
		public static readonly Guid МатериальныеРасходы = new Guid("d0019dbb-81a8-580b-4304-610cf518a03a");//Материальные расходы
		public static readonly Guid УдалитьСтраховыеВзносы = new Guid("030b849a-9225-c251-4a91-d948a1a6b242");//Удалить страховые взносы
		public static readonly Guid СтраховыеВзносы = new Guid("fe139a9d-8a02-845f-4c7e-6cff0ad2c61c");//Страховые взносы
		public static readonly Guid НалогиИСборы = new Guid("a5e20089-53ff-7c2c-443e-57bf4639d355");//Налоги и сборы
		public static readonly Guid НИОКР = new Guid("53bb3e95-8e88-bc5a-49c0-5038113f705a");
		public static readonly Guid НИОКРПоПеречнюПравительстваРФ = new Guid("ce769fba-73df-ac70-443c-86175afc2e52");//НИОКР по перечню Правительства РФ
		public static readonly Guid ОбязательноеИДобровольноеСтрахованиеИмущества = new Guid("a394f6a0-2768-ba92-4e16-eae4c074d7c1");//Обязательное и добровольное страхование имущества
		public static readonly Guid ПрочиеРасходы = new Guid("93b05087-ff2b-a8ce-4392-4d40f79afd23");//Прочие расходы
		public static readonly Guid ПредставительскиеРасходы = new Guid("70d5f991-d8de-6f0d-4e3a-7175adcdc111");//Представительские расходы
		public static readonly Guid РасходыНаРекламуНормируемые = new Guid("5b8ce78b-05e4-a668-4f81-e21a02fa23ad");//Расходы на рекламу (нормируемые)
		public static readonly Guid РемонтОсновныхСредств = new Guid("cbd8579c-9d8f-db2c-466a-84f7af8ab34b");//Ремонт основных средств
		public static readonly Guid РасходыНаВозмещениеЗатратРаботниковПоУплатеПроцентов = new Guid("2f8a74ae-cdc0-6295-45bc-17b370dd5007");//Расходы на возмещение затрат работников по уплате процентов
		public static readonly Guid ОсвоениеПриродныхРесурсов = new Guid("314d0280-bee4-e6d7-4656-41e5d14d1d70");//Освоение природных ресурсов
		public static readonly Guid НеУчитываемыеВЦеляхНалогообложения = new Guid("6c61dc82-d993-83d4-4a8c-971227be64a0");//Не учитываемые в целях налогообложения
		public static readonly Guid ЕСН = new Guid("3120a8b8-d4d2-ad62-48f2-785217bc7a24");
		public static readonly Guid ТранспортныеРасходы = new Guid("1bd03b87-9621-6a7d-4475-b47df123dae2");//Транспортные расходы
		public static ВидыРасходовНУ Получить(this ВидыРасходовНУ Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыРасходовНУ Получить(this ВидыРасходовНУ Значение, Guid Ссылка)
		{
			if(Ссылка == ОплатаТруда)
			{
				return ВидыРасходовНУ.ОплатаТруда;
			}
			else if(Ссылка == Амортизация)
			{
				return ВидыРасходовНУ.Амортизация;
			}
			else if(Ссылка == АрендаФедеральногоИМуниципальногоИмущества)
			{
				return ВидыРасходовНУ.АрендаФедеральногоИМуниципальногоИмущества;
			}
			else if(Ссылка == ДобровольноеЛичноеСтрахование)
			{
				return ВидыРасходовНУ.ДобровольноеЛичноеСтрахование;
			}
			else if(Ссылка == ДобровольноеЛичноеСтрахованиеНаСлучайСмертиИлиУтратыРаботоспособности)
			{
				return ВидыРасходовНУ.ДобровольноеЛичноеСтрахованиеНаСлучайСмертиИлиУтратыРаботоспособности;
			}
			else if(Ссылка == ДобровольноеСтрахованиеПоДоговорамДолгосрочногоСтрахованияЖизниРаботников)
			{
				return ВидыРасходовНУ.ДобровольноеСтрахованиеПоДоговорамДолгосрочногоСтрахованияЖизниРаботников;
			}
			else if(Ссылка == АмортизационнаяПремия)
			{
				return ВидыРасходовНУ.АмортизационнаяПремия;
			}
			else if(Ссылка == КомандировочныеРасходы)
			{
				return ВидыРасходовНУ.КомандировочныеРасходы;
			}
			else if(Ссылка == МатериальныеРасходы)
			{
				return ВидыРасходовНУ.МатериальныеРасходы;
			}
			else if(Ссылка == УдалитьСтраховыеВзносы)
			{
				return ВидыРасходовНУ.УдалитьСтраховыеВзносы;
			}
			else if(Ссылка == СтраховыеВзносы)
			{
				return ВидыРасходовНУ.СтраховыеВзносы;
			}
			else if(Ссылка == НалогиИСборы)
			{
				return ВидыРасходовНУ.НалогиИСборы;
			}
			else if(Ссылка == НИОКР)
			{
				return ВидыРасходовНУ.НИОКР;
			}
			else if(Ссылка == НИОКРПоПеречнюПравительстваРФ)
			{
				return ВидыРасходовНУ.НИОКРПоПеречнюПравительстваРФ;
			}
			else if(Ссылка == ОбязательноеИДобровольноеСтрахованиеИмущества)
			{
				return ВидыРасходовНУ.ОбязательноеИДобровольноеСтрахованиеИмущества;
			}
			else if(Ссылка == ПрочиеРасходы)
			{
				return ВидыРасходовНУ.ПрочиеРасходы;
			}
			else if(Ссылка == ПредставительскиеРасходы)
			{
				return ВидыРасходовНУ.ПредставительскиеРасходы;
			}
			else if(Ссылка == РасходыНаРекламуНормируемые)
			{
				return ВидыРасходовНУ.РасходыНаРекламуНормируемые;
			}
			else if(Ссылка == РемонтОсновныхСредств)
			{
				return ВидыРасходовНУ.РемонтОсновныхСредств;
			}
			else if(Ссылка == РасходыНаВозмещениеЗатратРаботниковПоУплатеПроцентов)
			{
				return ВидыРасходовНУ.РасходыНаВозмещениеЗатратРаботниковПоУплатеПроцентов;
			}
			else if(Ссылка == ОсвоениеПриродныхРесурсов)
			{
				return ВидыРасходовНУ.ОсвоениеПриродныхРесурсов;
			}
			else if(Ссылка == НеУчитываемыеВЦеляхНалогообложения)
			{
				return ВидыРасходовНУ.НеУчитываемыеВЦеляхНалогообложения;
			}
			else if(Ссылка == ЕСН)
			{
				return ВидыРасходовНУ.ЕСН;
			}
			else if(Ссылка == ТранспортныеРасходы)
			{
				return ВидыРасходовНУ.ТранспортныеРасходы;
			}
			return ВидыРасходовНУ.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыРасходовНУ Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыРасходовНУ Значение)
		{
			switch (Значение)
			{
				case ВидыРасходовНУ.ОплатаТруда: return ОплатаТруда;
				case ВидыРасходовНУ.Амортизация: return Амортизация;
				case ВидыРасходовНУ.АрендаФедеральногоИМуниципальногоИмущества: return АрендаФедеральногоИМуниципальногоИмущества;
				case ВидыРасходовНУ.ДобровольноеЛичноеСтрахование: return ДобровольноеЛичноеСтрахование;
				case ВидыРасходовНУ.ДобровольноеЛичноеСтрахованиеНаСлучайСмертиИлиУтратыРаботоспособности: return ДобровольноеЛичноеСтрахованиеНаСлучайСмертиИлиУтратыРаботоспособности;
				case ВидыРасходовНУ.ДобровольноеСтрахованиеПоДоговорамДолгосрочногоСтрахованияЖизниРаботников: return ДобровольноеСтрахованиеПоДоговорамДолгосрочногоСтрахованияЖизниРаботников;
				case ВидыРасходовНУ.АмортизационнаяПремия: return АмортизационнаяПремия;
				case ВидыРасходовНУ.КомандировочныеРасходы: return КомандировочныеРасходы;
				case ВидыРасходовНУ.МатериальныеРасходы: return МатериальныеРасходы;
				case ВидыРасходовНУ.УдалитьСтраховыеВзносы: return УдалитьСтраховыеВзносы;
				case ВидыРасходовНУ.СтраховыеВзносы: return СтраховыеВзносы;
				case ВидыРасходовНУ.НалогиИСборы: return НалогиИСборы;
				case ВидыРасходовНУ.НИОКР: return НИОКР;
				case ВидыРасходовНУ.НИОКРПоПеречнюПравительстваРФ: return НИОКРПоПеречнюПравительстваРФ;
				case ВидыРасходовНУ.ОбязательноеИДобровольноеСтрахованиеИмущества: return ОбязательноеИДобровольноеСтрахованиеИмущества;
				case ВидыРасходовНУ.ПрочиеРасходы: return ПрочиеРасходы;
				case ВидыРасходовНУ.ПредставительскиеРасходы: return ПредставительскиеРасходы;
				case ВидыРасходовНУ.РасходыНаРекламуНормируемые: return РасходыНаРекламуНормируемые;
				case ВидыРасходовНУ.РемонтОсновныхСредств: return РемонтОсновныхСредств;
				case ВидыРасходовНУ.РасходыНаВозмещениеЗатратРаботниковПоУплатеПроцентов: return РасходыНаВозмещениеЗатратРаботниковПоУплатеПроцентов;
				case ВидыРасходовНУ.ОсвоениеПриродныхРесурсов: return ОсвоениеПриродныхРесурсов;
				case ВидыРасходовНУ.НеУчитываемыеВЦеляхНалогообложения: return НеУчитываемыеВЦеляхНалогообложения;
				case ВидыРасходовНУ.ЕСН: return ЕСН;
				case ВидыРасходовНУ.ТранспортныеРасходы: return ТранспортныеРасходы;
			}
			return Guid.Empty;
		}
	}
}