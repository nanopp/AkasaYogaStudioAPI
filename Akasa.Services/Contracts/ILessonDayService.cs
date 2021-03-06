﻿using Akasa.Dto.POCOs;
using Akasa.Services.Core;

namespace Akasa.Services.Contracts
{
    public interface ILessonDayService: IAkasaService<LessonDayGetDto, LessonDayInsertDto, LessonDayUpdateDto>
    {
    }
}
