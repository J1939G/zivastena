<?php 
function date_humanize( $string , $language){
    if( $language == 'en-GB') {
        if( $string == '1'){
            $duration = "day";
        } else {
            $duration = "days";
        }
    } else {
        if( strpos($string, '1') !== false || ( strpos( $string, '½') !== false && strpos($string, '1') !== false )){
            $duration = "den";
        }
        else if ( strpos( $string, '½') !== false) {
            $duration = "dny";
        }
        else if ( $string+0 <= 4){
            $duration = "dny";
        }
        else {
            $duration = "dnů";
        }
    }
    return $string." ".$duration;
}


?>