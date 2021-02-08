START TRANSACTION;
DELETE FROM tab_rbac_permissions WHERE roleID = (SELECT Id FROM tab_rbac_roles WHERE NAME='SzymonJ');
INSERT INTO tab_rbac_permissions (roleID,claimType, claimValue) VALUES (7,'BoardAccess','LUJJJ');
INSERT INTO tab_rbac_permissions (roleID,claimType, claimValue) VALUES (7,'BoardAccess','LUJJa');
INSERT INTO tab_rbac_permissions (roleID,claimType, claimValue) VALUES (7,'BoardAccess','LUJJb');
COMMIT;