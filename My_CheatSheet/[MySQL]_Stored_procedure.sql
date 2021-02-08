BEGIN
	DECLARE roleIDD INT;
	INSERT INTO tab_rbac_roles (NAME) VALUES (roleName);
	SELECT LAST_INSERT_ID() INTO roleIDD;
	Insert into tab_rbac_permissions  (roleID,claimType,claimValue) SELECT roleIDD,claimType,claimValue FROM tab_rbac_permissions WHERE roleID = (Select Id From tab_rbac_roles where Name = 'User');
END


//OR whole code

CREATE DEFINER=`root`@`localhost` PROCEDURE `InheritClaimsFromUser`(
	IN `roleName` VARCHAR(50)
)
LANGUAGE SQL
NOT DETERMINISTIC
MODIFIES SQL DATA
SQL SECURITY DEFINER
COMMENT 'inheritsClaimsFromUserToNewCreatedUser'
BEGIN
	DECLARE roleIDD INT;
	INSERT INTO tab_rbac_roles (NAME) VALUES (roleName);
	SELECT LAST_INSERT_ID() INTO roleIDD;
	Insert into tab_rbac_permissions  (roleID,claimType,claimValue) SELECT roleIDD,claimType,claimValue FROM tab_rbac_permissions WHERE roleID = (Select Id From tab_rbac_roles where Name = 'User');
END