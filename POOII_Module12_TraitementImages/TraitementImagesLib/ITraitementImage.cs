﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module12_TraitementImages
{
    public interface ITraitementImage : ICloneable
    {
        object Clone();
        void TraiterImage(ImageManipulable p_image);
    }
}
