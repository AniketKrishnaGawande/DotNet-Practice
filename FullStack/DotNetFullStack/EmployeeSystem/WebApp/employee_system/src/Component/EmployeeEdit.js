import { useLocation } from "react-router-dom";
import { useEffect } from "react";
import { useState } from "react";
const EmployeeEdit=()=>{
    var state = useLocation().state;
 var [ob,setob]=useState();
    useEffect(()=>{
setob(...state.employee);

    },[]);
const sta=()=>{
return ob;
}

return(
    <div>
        welcome
        {sta()}
    </div>
);


}
export default EmployeeEdit;