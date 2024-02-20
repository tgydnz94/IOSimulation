using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstract
{
    public abstract class BaseModel
    {
        //Tüm sınıflarda yer alması gereken burada tanımlanacak. Ayrıca generic yapı kurulurken veri erişim katmanında da ihtiyaç duyacağımız bir sınıf. Engin hocanın çıplak sınıf kalmasın demesinin nedenlerinden biri diyebiliriz.

        public int Id { get; set; }
    }
}
