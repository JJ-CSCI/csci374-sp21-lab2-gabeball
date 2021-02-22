module Assignment

type AMPM = AM | PM

// This function checks if an hour value `h` is not in [1,12] range
let areHoursInvalid h = 
    if h > 12 || h<1 then true
    else false
   

// This function checks if a minute value `m` is not in [0,59] range
let areMinutesInvalid m =
    if m > 59 || m<0 then true
    else false
    

// This function creates a valid time tuple
//      use above functions: areHoursInvalid & areMinutesInvalid
let time h m ampm  :(int * int * AMPM) =
    if (areHoursInvalid h && areMinutesInvalid m ) then (12,0,ampm)
    elif areHoursInvalid h then (12,m,ampm)
    elif areMinutesInvalid m then (h,0,ampm)
    else (h,m,ampm)
    

// This function compares two times in tuple format
let lessThan (time1: int * int * AMPM) (time2: int * int * AMPM) :bool =
    let (h1,m1,ampm1) = time1
    let (h2, m2, ampm2) = time2
    //if (ampm1 < ampm2) then true
    //else false
    if h1 < h2 then true
    elif h1 = h2 then 
      if m1 < m2 then true
      elif m1=m2 then 
        if ampm1 = ampm2 then false
        elif ampm1 = PM then true
        else true 
      else false
      
    elif h2 > h1 then false  
    else false
