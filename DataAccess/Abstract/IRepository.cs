using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {

        /*IRepository, bizim bu projemizde generic yapıya sahip, diğer interface lerin miras aldığı bir yapı olarak tanımladık
         *Repositories klasöründeki reposlar kendi bağlantısı olan interface den miras alacak. Onlarda buradan.
         *Ordaki reposların, bu interface de yapılan her güncelllemeyle implemente ihtiyaç duymaması için Generic bir yapı oluşturulacak
         *Mesela burada listmethod eklendi. CategoryRepos.cs de hata verdi, burada lsitmethod miras alınmadı diyerek. Ders 17
         *Buradaki interface yapıları generic hale getirildi.
         */
        List<T> List();
        void Instert(T p);
        void Update(T p);
        void Delete(T p);

        List<T> ListMethod(Expression<Func<T, bool>> filter);//Func<>:Parametresi olmayan ancak geriye T delegatetinden değer döündüren metod. Sondaki filter ise metodun ismi. Bu metod miras alınamaz
    }
}
