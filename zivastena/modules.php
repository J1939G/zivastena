<?php
function date_humanize($string, $language)
{
    if ($string == null) {
        $duration = "";
    } elseif ($language == 'en-GB') {
        if ($string == '1') {
            $duration = "day";
        } else {
            $duration = "days";
        }
    } else {
        if (preg_match("/[1-9]\d/", $string)) {
            $duration = "dnů";
        } elseif (preg_match("/^(1|½|\.5)/", $string)) {
            $duration = "den";
        } elseif (preg_match("/^[1-4]/", $string)) {
            $duration = "dny";
        } else {
            $duration = "dnů";
        }
    }
    return $string." ".$duration;
}

function humanize_price($string, $language)
{
    if ($string == null || $string == '0' || $string == 0) {
        if ($language == 'en-GB') {
            $price = 'Private collection';
        } else {
            $price = 'Soukromá sbírka';
        }
    } else {
        $price = $string.' Kč';
    }
    return $price;
}

function humanize_size($string)
{
    if (preg_match("/[0-9]+x[0-9]+/", $string)) {
        $size = '<br>'.$string.' cm';
    } else {
        $size = "";
    }
    return $size;
}

function technique($string, $language)
{
    $techniquesEN = array(0 => 'Oil on canvass', 1 => 'Oil on wood', 2 => 'Oil on linen', 3 => 'Pastels on cotton', 4 => 'Acrilic on canvass', 5 => 'Oil over oak', 6 => 'Watercolour', 7 => 'Gold leaf and oil in wood');
    $techniquesCS = array(0 => 'Olej na platně', 1 => 'Olej na dřevě', 2 => 'Olej na len', 3 => 'Pastel na bavlnový papíře', 4 => 'Akryl na platně', 5 => 'Olej na dubu', 6 => 'Akvarely', 7 => 'Olej a platkové zlato na dřevě');
    if ($language != 'en-GB') {
        return $techniquesCS[array_search($string, $techniquesEN)];
    } else {
        return $string;
    }
}
