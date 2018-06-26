﻿namespace libMBIN.Models.Structs
{
    public class gcproducttableEnum : NMSTemplate
    {
        public int Product;
        public string[] ProductValues()
        {
            return new[] { "None", "CAVECUBE", "SENTINEL1", "SENTINEL2", "HACK1", "CURIO1", "CURIO2", "DRUGS1", "CURIO3", "CURIO4", "CURIO5",
                    "CURIO6", "CURIO7", "CURIO8", "CURIO9", "AQUASPHERE",
                    "SACVENOM", "GRAVBALL", "ALBUMENPEARL", "ACCESS1", "ACCESS2", "ACCESS3", "NIPNIPBUDS", "HYPERFUEL1", "GRENFUEL1",
                    "PRODFUEL1", "PRODFUEL2", "PRODFUEL3", "COMMODITY1", "COMMODITY4", "COMMODITY7", "SHIELDFUEL1", "SHIELDFUEL2", "SHIELDFUEL3",
                    "COMMODITY3", "COMMODITY5", "COMMODITY6", "COMMODITY2", "ALLOY1", "ALLOY2", "ALLOY3", "ALLOY4", "ALLOY5", "ALLOY6", "ALLOY7",
                    "ALLOY8", "BATTERY", "CWIRE", "MPLATE", "CBOARD", "GLASS", "SFIBRES", "ACID", "GEL", "LUBE", "EXPLOSIVE", "FARMPROD1",
                    "FARMPROD2", "FARMPROD3", "FARMPROD4", "FARMPROD5", "FARMPROD6", "FARMPROD7", "FARMPROD8", "FARMPROD9", "FARMPRODBASIC1",
                    "FARMPRODBASIC2", "REACTION1", "REACTION2", "REACTION3", "COMPOUND1", "COMPOUND2", "COMPOUND3", "COMPOUND4", "COMPOUND5",
                    "COMPOUND6", "MEGAPROD1", "MEGAPROD2", "MEGAPROD3", "ULTRAPROD1", "ULTRAPROD2", "POLICE_TOKEN", "TRA_ALLOY1", "TRA_ALLOY2",
                     "TRA_ALLOY3", "TRA_ALLOY4", "TRA_ALLOY5", "TRA_COMMODITY1", "TRA_COMMODITY2", "TRA_COMMODITY3", "TRA_COMMODITY4", "TRA_COMMODITY5",
                     "TRA_COMPONENT1", "TRA_COMPONENT2", "TRA_COMPONENT3", "TRA_COMPONENT4", "TRA_COMPONENT5", "TRA_ENERGY1", "TRA_ENERGY2", "TRA_ENERGY3",
                     "TRA_ENERGY4", "TRA_ENERGY5", "TRA_EXOTICS1", "TRA_EXOTICS2", "TRA_EXOTICS3", "TRA_EXOTICS4", "TRA_EXOTICS5", "TRA_MINERALS1", "TRA_MINERALS2",
                     "TRA_MINERALS3", "TRA_MINERALS4", "TRA_MINERALS5", "TRA_TECH1", "TRA_TECH2", "TRA_TECH3", "TRA_TECH4", "TRA_TECH5", "MIND_ARC", "ATLAS_SEED_1",
                     "ATLAS_SEED_2", "ATLAS_SEED_3", "ATLAS_SEED_4", "ATLAS_SEED_5", "ATLAS_SEED_6", "ATLAS_SEED_7", "ATLAS_SEED_8", "ATLAS_SEED_9", "ATLAS_SEED_10",
                     "FOUNDATION", "CORRIDOR", "CORRIDORL", "CORRIDORT", "CORRIDORX", "CORRIDOR_WINDOW", "HEALTHPLANT", "NPCEXPLORER001", "NPCSCIENCETERM", "NPCWEAPONTERM",
                    "NPCFARMTERM", "NPCVEHICLETERM", "NPCBUILDERTERM", "BUILDBEACON", "BUILDSIGNAL", "BUILDLANDINGPAD", "BUILDLADDER", "BUILDTERMINAL", "BUILDHARVESTER", "BUILDGASHARVESTER",
                     "BUILDDOOR", "FOUNDLEG", "MAINROOM", "BUILDWINDOW", "BUILDTOWER", "BUILDCHAIR", "BUILDCHAIR2", "BUILDCHAIR3", "BUILDTABLE", "BUILDTABLE2",
                     "BUILDTABLE3", "BUILDBED", "SMALLLIGHT", "BUILDLIGHT", "BUILDLIGHT2", "BUILDLIGHT3", "BUILDPAVING", "BUILDPAVINGTALL", "GARAGE_S", "GARAGE_M", "GARAGE_L", "CUBEROOM",
                    "CUBEFOUND", "CUBEFOUND4", "CUBEWINDOW", "BUILDSAVE", "CUBEFLOOR", "CUBELADDER", "BUILDDECAL", "BUILDDECAL2", "BUILDDECALHELLO", "BUILDDECALNMS",
                     "BUILDDECALNUM0", "BUILDDECALNUM1", "BUILDDECALNUM2", "BUILDDECALNUM3", "BUILDDECALNUM4", "BUILDDECALNUM5", "BUILDDECALNUM6", "BUILDDECALNUM7",
                     "BUILDDECALNUM8", "BUILDDECALNUM9", "FOUNDLEG4", "GLASSCORRIDOR", "BUILDRAMP", "SHIPSUMMON", "TECHPANEL", "WALLFAN", "WALLSCREEN", "PLANTPOT",
                     "BLDWALLUNIT", "CHEST", "MESSAGE", "PLANTER", "PLANTERMEGA", "CONTAINER0", "CONTAINER1", "CONTAINER2", "CONTAINER3", "CONTAINER4", "CONTAINER5",
                     "CONTAINER6", "CONTAINER7", "CONTAINER8", "CONTAINER9", "WALL", "CORNERPOST", "ROOMFLOOR", "CYLINDERSHAPE", "CUBESHAPE", "SPHERESHAPE", "CUBEWINDOWOVAL",
                     "CUBEWINDOWSMALL", "FLAG1", "FLAG2", "FLAG3", "FLAG4", "WALLFLAG1", "WALLFLAG2", "WALLFLAG3", "DRAWS", "SERVERSTACK", "FLOORMAT1", "ROOFMONITOR",
                     "CEILINGLIGHT", "MONITORDESK", "WALLDOOR", "LARGEDESK", "PLANTPOT1", "PLANTPOT2", "PLANTPOT3", "WEAPONRACK", "CURVEDDESK", "CRATELRARE", "CRATELCYLINDER",
                     "BIOROOM", "CURVEDCUBEROOF", "CUBEROOMCURVED", "CUBEGLASS", "CUBEFRAME", "CUBEINNERDOOR", "CUBEWALL", "CUBEROOF", "CUBESTAIRS", "DOOR2", "WALLFLOORLADDER",
                     "WALLLIGHTBLUE", "WALLLIGHTPINK", "WALLLIGHTYELLOW", "WALLLIGHTGREEN", "WALLLIGHTRED", "WALLLIGHTWHITE", "MAINROOMFRAME", "VIEWSPHERE", "CREATHOLOGRAM",
                     "CARBONPLANTER", "HEALTHSTATION", "SHIELDSTATION", "BUILDDECALVIS1", "BUILDDECALVIS2", "BUILDDECALVIS3", "BUILDDECALVIS4", "BUILDDECALVIS5", "BUILDDECALSIMP1",
                     "BUILDDECALSIMP2", "BUILDDECALSIMP3", "BUILDDECALSIMP4", "WALLTALL", "WEDGESHAPE", "WEDGESMALLSHAPE", "PYRAMIDSHAPE", "CURVEPIPESHAPE", "PIPESHAPE", "CUBESOLID",
                     "MESSAGEMODULE", "CORRIDORC", "MAINROOMCUBE", "RACE_START", "MAINROOMCUBEF", "WALLCURVED", "TOXICPLANT", "SNOWPLANT", "RADIOPLANT", "BARRENPLANT", "LUSHPLANT",
                     "SCORCHEDPLANT", "CREATUREPLANT", "POOPPLANT", "GRAVPLANT", "SACVENOMPLANT", "PEARLPLANT", "NIPPLANT" };
        }
    }
}
