
using System.Collections.Generic;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using OSCB.Helpers;
using Tekla.BIM.Geometry;
using Tekla.Common.Geometry;
using OSCB.Tekla3.Geometry;
using System.Linq;
using static Tekla.Structures.Plugins.PluginBase;
using System;
using Tekla.Structures.Datatype;
using OSCB.Tekla3.Initiators;

namespace OSCB.Plugin
{
    internal class PluginInitiator
    {


        public bool Run(List<InputDefinition> Input)
        {
            List<Part> modelParts = Input.GetMultipleModelparts(1);
            if (modelParts.Count == 0)
            {
                return false;
            }
            Beam beam = modelParts[0] as Beam;
      

            Solid part1solid = beam.GetSolid(Solid.SolidCreationTypeEnum.PLANECUTTED);

            List<Face3> part1solidfaces = part1solid.GetFaces().ToList();

            UnitVector3 direction = (beam.EndPoint - beam.StartPoint).ToVector3().GetNormalized();
            UnitVector3 perpendiculardirection = new UnitVector3(direction.Y, -direction.X, direction.Z);

            Segment3 segment = new Segment3(beam.StartPoint.ToVector3(), beam.EndPoint.ToVector3());

            Face3 closesFace = part1solidfaces.Where(f => f.Normal.ToPoint() == perpendiculardirection.ToPoint()).Aggregate((p1, p2) => p1.Points.First().DistanceTo(beam.StartPoint.ToVector3()) < p2.Points.First().DistanceTo(beam.StartPoint.ToVector3()) ? p1 : p2);

            double distance = System.Math.Round(closesFace.DistanceTo(beam.StartPoint.ToVector3()), 2);

            Segment3 frontsegment = new Segment3(segment.NegativeEnd + (distance * perpendiculardirection), segment.PositiveEnd + (distance * perpendiculardirection));

            ColumnInitiator column_new = new ColumnInitiator(new Vector3(0, 0, 0));
            column_new.RotationAngle = frontsegment.GetAngle(UnitVector3.UnitX);
            column_new.Height = 500;
            column_new.Insert();
            return true;
        }
    }
}
