create database kasperDB;

use kasperDB;

CREATE TABLE kasperdb.items (
  iditems INT NOT NULL,
  Name VARCHAR(50) NOT NULL,
  description VARCHAR(50) NULL,
  quantity INT NOT NULL,
  PRIMARY KEY (iditems));
  
USE `kasperdb`;
DROP procedure IF EXISTS `new_item`;

DELIMITER $$
USE `kasperdb`$$
CREATE PROCEDURE `new_item` (IN SPIdItem int, in SPname varchar(50), in SPdescription varchar(50), in SPquantity int)
BEGIN

insert into items(iditems,Name,description,quantity) values (SPIdItem,SPname,SPdescription,SPquantity);

END$$

DELIMITER ;

DELIMITER $$
USE `kasperdb`$$
CREATE PROCEDURE `item_in` (IN SPIdItem int,  in SPquantity int)
BEGIN

update items 
set quantity = quantity + SPquantity
where iditems = SPIdItem;

END$$

DELIMITER ;

DELIMITER $$
USE `kasperdb`$$
CREATE PROCEDURE `item_out` (IN SPIdItem int, in SPquantity int)
BEGIN

if (select quantity 
	from items
	where iditems = SPIdItem) >= SPquantity
then
        update items 
		set quantity =quantity- SPquantity
		where iditems = SPIdItem;
    end if;

END$$

DELIMITER ;

DELIMITER $$
USE `kasperdb`$$
CREATE PROCEDURE `listItems` (in SPType varchar(5), in spString varchar(50))
BEGIN

if (SPType)= "all" then
    select * 
	from items;
elseif (SPType)="name" then
    select * 
	from items
    where name like concat('%',spString,'%');
end if;

END$$

DELIMITER ;


call new_item(001,"Llanta","Llanta para tractocamion",12);
call item_in(001,5);
call item_out(001,13);
call listItems('all','anta');
select * from items;
