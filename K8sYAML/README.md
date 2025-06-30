# Pleasanter Kubernetes デプロイ手順

このREADMEは、`pleasanter` namespaceでPleasanter関連サービスをKubernetes上にデプロイする手順を示します。

## セットアップ手順

## 1. **Namespaceの作成**  
   まず、リソースをまとめるためのnamespaceを作成します

   ```sh
   kubectl apply -f pleasanter_namespace.yaml
   ```

2. **Secretの作成**  
   データベースやアプリケーションの接続情報など、機密情報をSecretとして登録します。

   ```sh
   kubectl apply -f pleasanter-db-secret.yaml -n pleasanter
   ```

3. **永続ボリュームクレーム（PVC）の作成**  
   PostgreSQLのデータ永続化用PVCを作成します（必要に応じて）。

   ```sh
   kubectl apply -f PersistentVolumeClaim.yaml -n pleasanter
   ```

4. **データベース（PostgreSQL）のデプロイとサービス作成**  
   データベースを先に起動し、他サービスが接続できるようにします。

   ```sh
   kubectl apply -f pleasanter-db_dp.yaml -n pleasanter
   kubectl apply -f pleasanter-db_sv.yaml -n pleasanter
   ```

5. **アプリケーション（Pleasanter, CodeDefiner）のデプロイとサービス作成**  
   データベースが起動した後、アプリケーション本体をデプロイします。

   ```sh
   kubectl apply -f pleasanter_dp.yaml -n pleasanter
   kubectl apply -f pleasanter_sv.yaml -n pleasanter
   kubectl apply -f codedefiner_dp.yaml -n pleasanter
   kubectl apply -f codedefiner_sv.yaml -n pleasanter
   ```

## 注意事項

- Secretの値はbase64エンコードしてください。
- PVC（pgdata-pvc.yaml）はクラスタ環境に合わせて作成・編集してください。
- サービスへのアクセスは`NodePort`や`Ingress`の設定により調整してください。

## 起動順について

1. **Namespace** → **Secret** → **PVC** → **DB** → **アプリケーション**
2. データベースが先に起動している必要があります。
3. アプリケーションはDBサービスが利用可能になってから起動します。

---