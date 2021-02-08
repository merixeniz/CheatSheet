//View

// @model DAL.Entities.UserPrivileges
// @*@ViewBag*@
// <html>
// <head>

// </head>
// <body>
//     <div>
//         <a>@Model.userName</a>
//         <form>
//             <div class="form-check">
//                 <a>Board claims</a>
//                 <input class="form-check-input" type="checkbox" value="" id="board_checkbox">
//                 <label class="form-check-label" for="board_checkbox">
//                     Board name
//                 </label>
//             </div>
//         </form>
//     </div>
//     <div class="btn-group">
//         <button type="button" class="btn btn-secondary" onclick="saveUser()">
//             Save
//         </button>
//     </div>
// </body>
// </html>


//Controller
public IActionResult UserPrivileges(string usrID, string usrLogin)
        {
            var privileges = _userManager.LoadUsersPrivileges(usrID, usrLogin);
            privileges.userID = int.Parse(usrID);
            privileges.userName = usrLogin;
            //ViewBag.Privileges = privileges;
            //TempData["UserPrivileges"] = privileges;
            return View("UserPrivileges", privileges);
        }
