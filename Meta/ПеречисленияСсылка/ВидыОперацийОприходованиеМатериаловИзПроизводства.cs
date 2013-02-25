﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Общ)
	///</summary>
	[DataContract]
	public enum ВидыОперацийОприходованиеМатериаловИзПроизводства
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"d0a97624-2a55-49fb-b1f5-c6f8d817c5e0\", \"Представление\":\"Материалы\"}")]
		Материалы = 0,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"dc4f78a1-9874-4f9a-8f24-60cdc198b938\", \"Представление\":\"ВозвратныеОтходы\"}")]
		ВозвратныеОтходы = 1,//возвратные отходы
	}
	public static partial class ВидыОперацийОприходованиеМатериаловИзПроизводства_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Материалы = new Guid("f8c6f5b1-17d8-e0c5-49fb-2a55d0a97624");
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозвратныеОтходы = new Guid("cd60248f-98c1-38b9-4f9a-9874dc4f78a1");//возвратные отходы
		public static ВидыОперацийОприходованиеМатериаловИзПроизводства Получить(this ВидыОперацийОприходованиеМатериаловИзПроизводства Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийОприходованиеМатериаловИзПроизводства Получить(this ВидыОперацийОприходованиеМатериаловИзПроизводства Значение, Guid Ссылка)
		{
			if(Ссылка == Материалы)
			{
				return ВидыОперацийОприходованиеМатериаловИзПроизводства.Материалы;
			}
			else if(Ссылка == ВозвратныеОтходы)
			{
				return ВидыОперацийОприходованиеМатериаловИзПроизводства.ВозвратныеОтходы;
			}
			return ВидыОперацийОприходованиеМатериаловИзПроизводства.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийОприходованиеМатериаловИзПроизводства Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийОприходованиеМатериаловИзПроизводства Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийОприходованиеМатериаловИзПроизводства.Материалы: return Материалы;
				case ВидыОперацийОприходованиеМатериаловИзПроизводства.ВозвратныеОтходы: return ВозвратныеОтходы;
			}
			return Guid.Empty;
		}
	}
}