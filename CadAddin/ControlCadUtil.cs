using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using CadServerLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAddin
{
    public class ControlCadUtil : ICadAddin
    {

        [CommandMethod("Demo")]
        public void Demo()
        {
            CadAddinUI mf = new CadAddinUI();
            mf.Show();
        }
        public ArrayList GetLayers()
        {
            ArrayList layers = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                LayerTable lyTab = trans.GetObject(db.LayerTableId, OpenMode.ForRead) as LayerTable;
                foreach (var ly in lyTab)
                {
                    LayerTableRecord lytr = trans.GetObject(ly, OpenMode.ForRead) as LayerTableRecord;
                    layers.Add(lytr.Name);
                }
            }

            return layers;
        }
        public ArrayList GetLineTypes()
        {
            ArrayList lineTypes = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                LinetypeTable liTab = trans.GetObject(db.LinetypeTableId, OpenMode.ForRead) as LinetypeTable;
                foreach (var li in liTab)
                {
                    LinetypeTableRecord litr = trans.GetObject(li, OpenMode.ForRead) as LinetypeTableRecord;
                    lineTypes.Add(litr.Name);
                }
            }

            return lineTypes;
        }
        public ArrayList GetTextStyles()
        {
            ArrayList textstyles = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                TextStyleTable stTab = trans.GetObject(db.TextStyleTableId, OpenMode.ForRead) as TextStyleTable;
                foreach (var st in stTab)
                {
                    TextStyleTableRecord sttr = trans.GetObject(st, OpenMode.ForRead) as TextStyleTableRecord;
                    textstyles.Add(sttr.Name);
                }
            }

            return textstyles;
        }
    }
}

