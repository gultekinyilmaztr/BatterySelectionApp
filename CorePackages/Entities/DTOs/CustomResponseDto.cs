using CorePackages.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CorePackages.Entities.DTOs
{
    public class CustomResponseDto<T>
    {

        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public List<String> Errors { get; set; }


        public static CustomResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomResponseDto<T> { Data = data, StatusCode = statusCode };
        }
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode };
        }

        public static CustomResponseDto<T> Fail(int statusCode, List<string> errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = errors };
        }

        public static CustomResponseDto<T> Fail(int statusCode, string error)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }

    }
}


//Bu kod, genel olarak bir HTTP API'den alınan veya gönderilen cevapları temsil etmek üzere oluşturulmuş bir sınıf olan CustomResponseDto<T>'yi içerir. Bu sınıf, çeşitli durumlar için kullanılabilen bir özel (custom) cevap türüdür. İşte bu sınıfın özellikleri ve metodları:

//public T Data { get; set; }: Generic olarak belirtilmiş olan Data özelliği, cevapta taşınan veriyi temsil eder. Örneğin, bir API çağrısının başarılı olması durumunda dönen veri bu özellik aracılığıyla taşınabilir.

//[JsonIgnore] public int StatusCode { get; set; }: StatusCode özelliği, HTTP yanıt durum kodunu temsil eder. Bu özellik, JSON dönüşlerinde kullanılmak üzere işlemlerde göz ardı edilir ([JsonIgnore] attributu ile işaretlenmiştir).

//public List<string> Errors { get; set; }: Errors özelliği, eğer bir hata durumu söz konusuysa bu hataları içeren bir liste sağlar.

//public static CustomResponseDto<T> Success(int statusCode, T data): Başarı durumunu temsil eden bu statik metod, başarılı bir yanıt oluşturur ve Data özelliğine veriyi ekler.

//public static CustomResponseDto<T> Success(int statusCode): Yine başarı durumunu temsil eden bu statik metod, sadece bir durum kodu içeren başarılı bir yanıt oluşturur.

//public static CustomResponseDto<T> Fail(int statusCode, List<string> errors): Hata durumunu temsil eden bu statik metod, belirli bir durum kodu ve hata listesi içeren bir yanıt oluşturur.

//public static CustomResponseDto<T> Fail(int statusCode, string error): Tek bir hata mesajını içeren bir hata durumu için kullanılan bu statik metod, belirli bir durum kodu ve tek bir hata içeren bir yanıt oluşturur.

//Bu tür bir yapı, özellikle bir HTTP API tarafından gönderilen veya alınan yanıtları daha düzenli ve özel bir formatta işlemek için kullanışlıdır. Data özelliği başarılı durumlarda geri dönen veriyi taşırken, Errors özelliği hata durumlarında oluşan hataları içerir. StatusCode ise HTTP yanıt durum kodunu temsil eder.
