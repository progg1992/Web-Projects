import { Module } from '@nestjs/common';
import { UserService } from './service/user.service';
import { UserController } from './controller/user.controller';
import { TypeOrmModule } from '@nestjs/typeorm';
import { UserEntity } from './model/user.entity';
<<<<<<< HEAD
import { AuthModule } from 'src/auth/auth.module';

@Module({
  imports: [
    TypeOrmModule.forFeature([UserEntity]),
    AuthModule
=======

@Module({
  imports: [
    TypeOrmModule.forFeature([UserEntity])
>>>>>>> cb660b093820e831ec0c8d15c6816f25b3cca0b1
  ],
  providers: [UserService],
  controllers: [UserController]
})
export class UserModule {}
