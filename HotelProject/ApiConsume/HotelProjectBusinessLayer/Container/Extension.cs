using HotelProjectBusinessLayer.Abstract;
using HotelProjectBusinessLayer.Concrete;
using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusinessLayer.Container
{
    public static class Extension
    {
        public static void ContainerDepencies(this IServiceCollection services)
        {
            services.AddScoped<IStaffService, StaffManager>();
            services.AddScoped<IStaffDal, EfStaffRepo>();

            services.AddScoped<IRoomService, RoomManager>();
            services.AddScoped<IRoomDal, EfRoomRepo>();

            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceDal, EfServiceRepo>();

            services.AddScoped<ISubscribeService, SubscribeManager>();
            services.AddScoped<ISubscribeDal, EfSubscribeRepo>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialRepo>();

            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDal, EfAboutRepo>();

            services.AddScoped<IBookingService, BookingManager>();
            services.AddScoped<IBookingDal, EfBookingRepo>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EfContactRepo>();

            services.AddScoped<IGuestService, GuestManager>();
            services.AddScoped<IGuestDal, EfGuestRepo>();

            services.AddScoped<ISendMessageService, SendMessageManager>();
            services.AddScoped<ISendMessageDal, EfSendMessageRepo>();

            services.AddScoped<IMessageCategoryService, MessageCategoryManager>();
            services.AddScoped<IMessageCategoryDal, EfMessageCategoryRepo>();

            services.AddScoped<IWorkLocationService, WorkLocationManager>();
            services.AddScoped<IWorkLocationDal, EfWorkLocationRepo>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IUserDal, EfAppUserRepo>();
        }
    }
}
