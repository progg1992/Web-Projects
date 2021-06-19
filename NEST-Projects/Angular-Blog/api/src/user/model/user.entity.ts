<<<<<<< HEAD
import { BeforeInsert, Column, Entity, PrimaryGeneratedColumn } from 'typeorm'
=======
import { Column, Entity, PrimaryGeneratedColumn } from 'typeorm'
>>>>>>> cb660b093820e831ec0c8d15c6816f25b3cca0b1

@Entity()
export class UserEntity {
  	@PrimaryGeneratedColumn()
	id: number;
	
	@Column()
	name: string;

	@Column({unique: true})
	username: string;
<<<<<<< HEAD

	@Column()
	email: string;

	@Column()
	password: string;

	@BeforeInsert()
	emailToLowerCase() {
		this.email = this.email.toLowerCase();
	}
=======
>>>>>>> cb660b093820e831ec0c8d15c6816f25b3cca0b1
}