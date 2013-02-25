﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"a1539bf8-ba4c-4757-b635-a733498dcf22\", \"Представление\":\"Сценарий\"}")]
		Сценарий = 0,//Данные сценария
		[EnumMember(Value = "{\"Ссылка\":\"43dbaab9-2933-41c2-9f0d-de056b60ed7d\", \"Представление\":\"ФактическиеДанные\"}")]
		ФактическиеДанные = 1,//Фактические данные
	}
	public static partial class ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Сценарий = new Guid("33a735b6-8d49-22cf-4757-ba4ca1539bf8");//Данные сценария
		public static readonly Guid ФактическиеДанные = new Guid("05de0d9f-606b-7ded-41c2-293343dbaab9");//Фактические данные
		public static ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал Получить(this ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал Получить(this ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал Значение, Guid Ссылка)
		{
			if(Ссылка == Сценарий)
			{
				return ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал.Сценарий;
			}
			else if(Ссылка == ФактическиеДанные)
			{
				return ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал.ФактическиеДанные;
			}
			return ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал Значение)
		{
			switch (Значение)
			{
				case ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал.Сценарий: return Сценарий;
				case ВидыДанныхДляПланФактногоАнализаЗатратНаПерсонал.ФактическиеДанные: return ФактическиеДанные;
			}
			return Guid.Empty;
		}
	}
}