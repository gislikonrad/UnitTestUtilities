using Moq.Language;
using Moq.Language.Flow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestUtilities
{
	public static class MockExtensions
	{
		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T">The type of the first argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T>(this ICallback mock, Func<T, Exception> func)
		{
			mock.Callback<T>(
				(t) =>
				{
					throw func(t);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2>(this ICallback mock, Func<T1, T2, Exception> func)
		{
			mock.Callback<T1, T2>(
				(t1, t2) =>
				{
					throw func(t1, t2);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3>(this ICallback mock, Func<T1, T2, T3, Exception> func)
		{
			mock.Callback<T1, T2, T3>(
				(t1, t2, t3) =>
				{
					throw func(t1, t2, t3);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4>(this ICallback mock, Func<T1, T2, T3, T4, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4>(
				(t1, t2, t3, t4) =>
				{
					throw func(t1, t2, t3, t4);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5>(this ICallback mock, Func<T1, T2, T3, T4, T5, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5>(
				(t1, t2, t3, t4, t5) =>
				{
					throw func(t1, t2, t3, t4, t5);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <typeparam name="T6">The type of the sixth argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5, T6>(this ICallback mock, Func<T1, T2, T3, T4, T5, T6, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5, T6>(
				(t1, t2, t3, t4, t5, t6) =>
				{
					throw func(t1, t2, t3, t4, t5, t6);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <typeparam name="T6">The type of the sixth argument of the invoked method.</typeparam>
		/// <typeparam name="T7">The type of the seventh argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5, T6, T7>(this ICallback mock, Func<T1, T2, T3, T4, T5, T6, T7, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5, T6, T7>(
				(t1, t2, t3, t4, t5, t6, t7) =>
				{
					throw func(t1, t2, t3, t4, t5, t6, t7);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <typeparam name="T6">The type of the sixth argument of the invoked method.</typeparam>
		/// <typeparam name="T7">The type of the seventh argument of the invoked method.</typeparam>
		/// <typeparam name="T8">The type of the eighth argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5, T6, T7, T8>(this ICallback mock, Func<T1, T2, T3, T4, T5, T6, T7, T8, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5, T6, T7, T8>(
				(t1, t2, t3, t4, t5, t6, t7, t8) =>
				{
					throw func(t1, t2, t3, t4, t5, t6, t7, t8);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <typeparam name="T6">The type of the sixth argument of the invoked method.</typeparam>
		/// <typeparam name="T7">The type of the seventh argument of the invoked method.</typeparam>
		/// <typeparam name="T8">The type of the eighth argument of the invoked method.</typeparam>
		/// <typeparam name="T9">The type of the ninth argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ICallback mock, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
				(t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
				{
					throw func(t1, t2, t3, t4, t5, t6, t7, t8, t9);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <typeparam name="T6">The type of the sixth argument of the invoked method.</typeparam>
		/// <typeparam name="T7">The type of the seventh argument of the invoked method.</typeparam>
		/// <typeparam name="T8">The type of the eighth argument of the invoked method.</typeparam>
		/// <typeparam name="T9">The type of the ninth argument of the invoked method.</typeparam>
		/// <typeparam name="T10">The type of the tenth argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ICallback mock, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
				(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
				{
					throw func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <typeparam name="T6">The type of the sixth argument of the invoked method.</typeparam>
		/// <typeparam name="T7">The type of the seventh argument of the invoked method.</typeparam>
		/// <typeparam name="T8">The type of the eighth argument of the invoked method.</typeparam>
		/// <typeparam name="T9">The type of the ninth argument of the invoked method.</typeparam>
		/// <typeparam name="T10">The type of the tenth argument of the invoked method.</typeparam>
		/// <typeparam name="T11">The type of the eleventh argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ICallback mock, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
				(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
				{
					throw func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <typeparam name="T6">The type of the sixth argument of the invoked method.</typeparam>
		/// <typeparam name="T7">The type of the seventh argument of the invoked method.</typeparam>
		/// <typeparam name="T8">The type of the eighth argument of the invoked method.</typeparam>
		/// <typeparam name="T9">The type of the ninth argument of the invoked method.</typeparam>
		/// <typeparam name="T10">The type of the tenth argument of the invoked method.</typeparam>
		/// <typeparam name="T11">The type of the eleventh argument of the invoked method.</typeparam>
		/// <typeparam name="T12">The type of the twelfth argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ICallback mock, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
				(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
				{
					throw func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <typeparam name="T6">The type of the sixth argument of the invoked method.</typeparam>
		/// <typeparam name="T7">The type of the seventh argument of the invoked method.</typeparam>
		/// <typeparam name="T8">The type of the eighth argument of the invoked method.</typeparam>
		/// <typeparam name="T9">The type of the ninth argument of the invoked method.</typeparam>
		/// <typeparam name="T10">The type of the tenth argument of the invoked method.</typeparam>
		/// <typeparam name="T11">The type of the eleventh argument of the invoked method.</typeparam>
		/// <typeparam name="T12">The type of the twelfth argument of the invoked method.</typeparam>
		/// <typeparam name="T13">The type of the thirteenth argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ICallback mock, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
				(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) =>
				{
					throw func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <typeparam name="T6">The type of the sixth argument of the invoked method.</typeparam>
		/// <typeparam name="T7">The type of the seventh argument of the invoked method.</typeparam>
		/// <typeparam name="T8">The type of the eighth argument of the invoked method.</typeparam>
		/// <typeparam name="T9">The type of the ninth argument of the invoked method.</typeparam>
		/// <typeparam name="T10">The type of the tenth argument of the invoked method.</typeparam>
		/// <typeparam name="T11">The type of the eleventh argument of the invoked method.</typeparam>
		/// <typeparam name="T12">The type of the twelfth argument of the invoked method.</typeparam>
		/// <typeparam name="T13">The type of the thirteenth argument of the invoked method.</typeparam>
		/// <typeparam name="T14">The type of the fourteenth argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ICallback mock, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
				(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) =>
				{
					throw func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <typeparam name="T6">The type of the sixth argument of the invoked method.</typeparam>
		/// <typeparam name="T7">The type of the seventh argument of the invoked method.</typeparam>
		/// <typeparam name="T8">The type of the eighth argument of the invoked method.</typeparam>
		/// <typeparam name="T9">The type of the ninth argument of the invoked method.</typeparam>
		/// <typeparam name="T10">The type of the tenth argument of the invoked method.</typeparam>
		/// <typeparam name="T11">The type of the eleventh argument of the invoked method.</typeparam>
		/// <typeparam name="T12">The type of the twelfth argument of the invoked method.</typeparam>
		/// <typeparam name="T13">The type of the thirteenth argument of the invoked method.</typeparam>
		/// <typeparam name="T14">The type of the fourteenth argument of the invoked method.</typeparam>
		/// <typeparam name="T15">The type of the fifteenth argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ICallback mock, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
				(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) =>
				{
					throw func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
				});
			return mock as IThrowsResult;
		}

		/// <summary>
		/// Specifies a factory method to create an exception to be thrown
		/// </summary>
		/// <typeparam name="T1">The type of the first argument of the invoked method.</typeparam>
		/// <typeparam name="T2">The type of the second argument of the invoked method.</typeparam>
		/// <typeparam name="T3">The type of the third argument of the invoked method.</typeparam>
		/// <typeparam name="T4">The type of the fourth argument of the invoked method.</typeparam>
		/// <typeparam name="T5">The type of the fifth argument of the invoked method.</typeparam>
		/// <typeparam name="T6">The type of the sixth argument of the invoked method.</typeparam>
		/// <typeparam name="T7">The type of the seventh argument of the invoked method.</typeparam>
		/// <typeparam name="T8">The type of the eighth argument of the invoked method.</typeparam>
		/// <typeparam name="T9">The type of the ninth argument of the invoked method.</typeparam>
		/// <typeparam name="T10">The type of the tenth argument of the invoked method.</typeparam>
		/// <typeparam name="T11">The type of the eleventh argument of the invoked method.</typeparam>
		/// <typeparam name="T12">The type of the twelfth argument of the invoked method.</typeparam>
		/// <typeparam name="T13">The type of the thirteenth argument of the invoked method.</typeparam>
		/// <typeparam name="T14">The type of the fourteenth argument of the invoked method.</typeparam>
		/// <typeparam name="T15">The type of the fifteenth argument of the invoked method.</typeparam>
		/// <typeparam name="T16">The type of the sixteenth argument of the invoked method.</typeparam>
		/// <param name="mock">The Mock object.</param>
		/// <param name="func">The factory method that creates an exception to be thrown.</param>
		/// <returns></returns>
		public static IThrowsResult Throws<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ICallback mock, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Exception> func)
		{
			mock.Callback<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
				(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) =>
				{
					throw func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
				});
			return mock as IThrowsResult;
		}

	}
}