namespace VenstarIPControl101;
        // class declarations
         class Venstar;
     class Venstar 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION VenstarIP ( STRING iptxt );
        STRING_FUNCTION FanTo0 ();
        STRING_FUNCTION FanTo1 ();
        STRING_FUNCTION ModeTo0 ();
        STRING_FUNCTION ModeTo1 ();
        STRING_FUNCTION ModeTo2 ();
        STRING_FUNCTION ModeTo3 ();
        STRING_FUNCTION HeatTempUp ();
        STRING_FUNCTION HeatTempDown ();
        STRING_FUNCTION CoolTempUp ();
        STRING_FUNCTION CoolTempDown ();
        STRING_FUNCTION QueryInfo ();
        STRING_FUNCTION SensorQueryInfo ();
        FUNCTION InfoFbHandler ( STRING responsein );
        FUNCTION SensorFbHandler ( STRING responsein );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER ModeFb;
        INTEGER FanFb;
        INTEGER SpaceTempFb;
        INTEGER FanStateFb;
        INTEGER AwayFb;
        STRING HeatTempFb[];
        STRING CoolTempFb[];
        STRING SensorNameFb[];
        INTEGER SensorTempFb;

        // class properties
    };

