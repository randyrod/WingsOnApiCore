namespace WingsOnApiCore.Services.Concrete
{
    public class ServiceBase
    {
        protected WingsOnDbContext DbContext;

        protected ServiceBase()
        {
            DbContext = new WingsOnDbContext();
        }
    }
}