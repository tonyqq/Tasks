create table transfers (
      sender varchar(20) not null,
      recipient varchar(20) not null,
      date date not null,
      amount integer not null
  );

INSERT INTO transfers (sender, recipient, date, amount)
VALUES ('Smith','Williams','2000-01-01',200);

INSERT INTO transfers (sender, recipient, date, amount)
VALUES ('Smith','Taylor','2002-09-27',1024);

INSERT INTO transfers (sender, recipient, date, amount)
VALUES ('Smith','Johnson','2005-06-26',512);

INSERT INTO transfers (sender, recipient, date, amount)
VALUES ('Williams','Johnson','2010-12-17',100);

INSERT INTO transfers (sender, recipient, date, amount)
VALUES ('Williams','Johnson','2004-03-22',10);

INSERT INTO transfers (sender, recipient, date, amount)
VALUES ('Brown','Johnson','2013-03-20',500);

INSERT INTO transfers (sender, recipient, date, amount)
VALUES ('Johnson','Williams','2007-06-02',400);

INSERT INTO transfers (sender, recipient, date, amount)
VALUES ('Johnson','Williams','2005-06-26',400);

INSERT INTO transfers (sender, recipient, date, amount)
VALUES ('Johnson','Williams','2005-06-26',200);

with combinations as
(SELECT distinct a.recipient,  a.amount as a1, b.amount as a2, c.amount as a3,
(IsNull(a.amount, 0) + IsNull(b.amount, 0) + IsNull(c.amount, 0)) as total_sum

  FROM transfers a
  left join transfers b
  on a.recipient = b.recipient and a.date <> b.date

  left join transfers c
  on a.recipient = b.recipient and b.recipient = c.recipient and a.recipient = c.recipient and 
  a.date <> b.date and b.date <> c.date and a.date <> c.date
 )
 select distinct recipient from combinations
 where total_sum > 1000
