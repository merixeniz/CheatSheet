var scanerConf = $("form").serializeArray();
                    let objParams = {};
                    scanerConf.forEach(scanerParam => {
                        objParams[scanerParam.name] = scanerParam.value;
                    })
                    
                    //Sending to controller
                    $.post('@Url.Action("AddNewScaner_11", "DeviceConfigurator")',
                        {
                            scanerC: JSON.stringify(objParams)
                        });



//2nd approach

function saveUser() {
    debugger;
    var form = document.getElementById("form");
    var formArray = Array.from(form);
    var objPriveleges = {}
    formArray.forEach(element => {
        objPriveleges[element.name] = element.value;
    })
    console.log(objPriveleges);
    //var formArray  = Array.from(form);
}