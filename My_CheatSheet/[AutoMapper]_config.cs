using AutoMapper;
//add AutoMepper.DependencyInjection

//maping in class:
_mapper.Map<DraftDTO, BoardDTO>(boardDraft);

//Create mapping profile class, to add exception or diferences in fields
public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<DraftDTO, BoardDTO>()
                .ForMember(boardDTO => boardDTO.Id, opt => opt.Ignore());
        }
    }

    //im DI config:
                services.AddAutoMapper(Assembly.GetExecutingAssembly());
