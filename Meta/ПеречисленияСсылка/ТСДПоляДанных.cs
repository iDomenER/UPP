﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ТСДПоляДанных
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"c74c0136-acfe-4f44-ad79-7d890b284412\", \"Представление\":\"ШтрихКод\"}")]
		ШтрихКод = 0,
		[EnumMember(Value = "{\"Ссылка\":\"de2cb333-b915-449a-8e27-6de4356e55c0\", \"Представление\":\"НоменклатураНаименование\"}")]
		НоменклатураНаименование = 1,//Наименование номенклатуры
		[EnumMember(Value = "{\"Ссылка\":\"f59ef0e8-1f7d-41e5-b5ce-e570b4b789fe\", \"Представление\":\"НоменклатураАртикул\"}")]
		НоменклатураАртикул = 2,//Артикул номенклатуры
		[EnumMember(Value = "{\"Ссылка\":\"0404acd6-4967-4f12-9fb5-4258b4ce59f5\", \"Представление\":\"НоменклатураХарактеристика\"}")]
		НоменклатураХарактеристика = 3,//Характеристика номенклатуры
		[EnumMember(Value = "{\"Ссылка\":\"277960f3-2642-45f1-8e2b-f9dedeeaeb6b\", \"Представление\":\"НоменклатураСерия\"}")]
		НоменклатураСерия = 4,//Серия номенклатуры
		[EnumMember(Value = "{\"Ссылка\":\"a5c68d14-964e-4fd1-acf1-177facfcde35\", \"Представление\":\"НоменклатураИзмерение\"}")]
		НоменклатураИзмерение = 5,//Единица измерения номенклатуры
		[EnumMember(Value = "{\"Ссылка\":\"4771a6a8-d756-43f3-abd4-28735bed7e59\", \"Представление\":\"НоменклатураКод\"}")]
		НоменклатураКод = 6,//Код номенклатуры
		[EnumMember(Value = "{\"Ссылка\":\"7730b75f-094e-49e2-b3ca-0b5e9d7d1844\", \"Представление\":\"НоменклатураЦена\"}")]
		НоменклатураЦена = 7,//Цена номенклатуры
		[EnumMember(Value = "{\"Ссылка\":\"0a1646af-12cf-4c07-a163-4c90cc15a351\", \"Представление\":\"КоличествоНаСкладе\"}")]
		КоличествоНаСкладе = 8,//Количество на складе
		[EnumMember(Value = "{\"Ссылка\":\"029d2fa2-0c2b-4809-86ed-55e0e4156c12\", \"Представление\":\"Качество\"}")]
		Качество = 9,
	}
	public static partial class ТСДПоляДанных_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ШтрихКод = new Guid("897d79ad-280b-1244-4f44-acfec74c0136");
		public static readonly Guid НоменклатураНаименование = new Guid("e46d278e-6e35-c055-449a-b915de2cb333");//Наименование номенклатуры
		public static readonly Guid НоменклатураАртикул = new Guid("70e5ceb5-b7b4-fe89-41e5-1f7df59ef0e8");//Артикул номенклатуры
		public static readonly Guid НоменклатураХарактеристика = new Guid("5842b59f-ceb4-f559-4f12-49670404acd6");//Характеристика номенклатуры
		public static readonly Guid НоменклатураСерия = new Guid("def92b8e-eade-6beb-45f1-2642277960f3");//Серия номенклатуры
		public static readonly Guid НоменклатураИзмерение = new Guid("7f17f1ac-fcac-35de-4fd1-964ea5c68d14");//Единица измерения номенклатуры
		public static readonly Guid НоменклатураКод = new Guid("7328d4ab-ed5b-597e-43f3-d7564771a6a8");//Код номенклатуры
		public static readonly Guid НоменклатураЦена = new Guid("5e0bcab3-7d9d-4418-49e2-094e7730b75f");//Цена номенклатуры
		public static readonly Guid КоличествоНаСкладе = new Guid("904c63a1-15cc-51a3-4c07-12cf0a1646af");//Количество на складе
		public static readonly Guid Качество = new Guid("e055ed86-15e4-126c-4809-0c2b029d2fa2");
		public static ТСДПоляДанных Получить(this ТСДПоляДанных Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТСДПоляДанных Получить(this ТСДПоляДанных Значение, Guid Ссылка)
		{
			if(Ссылка == ШтрихКод)
			{
				return ТСДПоляДанных.ШтрихКод;
			}
			else if(Ссылка == НоменклатураНаименование)
			{
				return ТСДПоляДанных.НоменклатураНаименование;
			}
			else if(Ссылка == НоменклатураАртикул)
			{
				return ТСДПоляДанных.НоменклатураАртикул;
			}
			else if(Ссылка == НоменклатураХарактеристика)
			{
				return ТСДПоляДанных.НоменклатураХарактеристика;
			}
			else if(Ссылка == НоменклатураСерия)
			{
				return ТСДПоляДанных.НоменклатураСерия;
			}
			else if(Ссылка == НоменклатураИзмерение)
			{
				return ТСДПоляДанных.НоменклатураИзмерение;
			}
			else if(Ссылка == НоменклатураКод)
			{
				return ТСДПоляДанных.НоменклатураКод;
			}
			else if(Ссылка == НоменклатураЦена)
			{
				return ТСДПоляДанных.НоменклатураЦена;
			}
			else if(Ссылка == КоличествоНаСкладе)
			{
				return ТСДПоляДанных.КоличествоНаСкладе;
			}
			else if(Ссылка == Качество)
			{
				return ТСДПоляДанных.Качество;
			}
			return ТСДПоляДанных.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТСДПоляДанных Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТСДПоляДанных Значение)
		{
			switch (Значение)
			{
				case ТСДПоляДанных.ШтрихКод: return ШтрихКод;
				case ТСДПоляДанных.НоменклатураНаименование: return НоменклатураНаименование;
				case ТСДПоляДанных.НоменклатураАртикул: return НоменклатураАртикул;
				case ТСДПоляДанных.НоменклатураХарактеристика: return НоменклатураХарактеристика;
				case ТСДПоляДанных.НоменклатураСерия: return НоменклатураСерия;
				case ТСДПоляДанных.НоменклатураИзмерение: return НоменклатураИзмерение;
				case ТСДПоляДанных.НоменклатураКод: return НоменклатураКод;
				case ТСДПоляДанных.НоменклатураЦена: return НоменклатураЦена;
				case ТСДПоляДанных.КоличествоНаСкладе: return КоличествоНаСкладе;
				case ТСДПоляДанных.Качество: return Качество;
			}
			return Guid.Empty;
		}
	}
}