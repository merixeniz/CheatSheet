//in view

@foreach(var user in ViewBag.Users)
    {
        <a>@user.login</a>
    }

    //in controller

    public IActionResult Main()
        {
            ViewBag.Users = _userManager.LoadUsers();
            return View("Main");
        }