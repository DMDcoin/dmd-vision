using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using DMDVision.Contracts.BlockRewardHbbftCoins.ContractDefinition;

namespace DMDVision.Contracts.BlockRewardHbbftCoins
{
    public partial class BlockRewardHbbftCoinsService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, BlockRewardHbbftCoinsDeployment blockRewardHbbftCoinsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<BlockRewardHbbftCoinsDeployment>().SendRequestAndWaitForReceiptAsync(blockRewardHbbftCoinsDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, BlockRewardHbbftCoinsDeployment blockRewardHbbftCoinsDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<BlockRewardHbbftCoinsDeployment>().SendRequestAsync(blockRewardHbbftCoinsDeployment);
        }

        public static async Task<BlockRewardHbbftCoinsService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, BlockRewardHbbftCoinsDeployment blockRewardHbbftCoinsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, blockRewardHbbftCoinsDeployment, cancellationTokenSource);
            return new BlockRewardHbbftCoinsService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public BlockRewardHbbftCoinsService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> REWARD_PERCENT_MULTIPLIERQueryAsync(REWARD_PERCENT_MULTIPLIERFunction rEWARD_PERCENT_MULTIPLIERFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<REWARD_PERCENT_MULTIPLIERFunction, BigInteger>(rEWARD_PERCENT_MULTIPLIERFunction, blockParameter);
        }

        
        public Task<BigInteger> REWARD_PERCENT_MULTIPLIERQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<REWARD_PERCENT_MULTIPLIERFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> VALIDATOR_MIN_REWARD_PERCENTQueryAsync(VALIDATOR_MIN_REWARD_PERCENTFunction vALIDATOR_MIN_REWARD_PERCENTFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<VALIDATOR_MIN_REWARD_PERCENTFunction, BigInteger>(vALIDATOR_MIN_REWARD_PERCENTFunction, blockParameter);
        }

        
        public Task<BigInteger> VALIDATOR_MIN_REWARD_PERCENTQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<VALIDATOR_MIN_REWARD_PERCENTFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> AddToDeltaPotRequestAsync(AddToDeltaPotFunction addToDeltaPotFunction)
        {
             return ContractHandler.SendRequestAsync(addToDeltaPotFunction);
        }

        public Task<string> AddToDeltaPotRequestAsync()
        {
             return ContractHandler.SendRequestAsync<AddToDeltaPotFunction>();
        }

        public Task<TransactionReceipt> AddToDeltaPotRequestAndWaitForReceiptAsync(AddToDeltaPotFunction addToDeltaPotFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addToDeltaPotFunction, cancellationToken);
        }

        public Task<TransactionReceipt> AddToDeltaPotRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<AddToDeltaPotFunction>(null, cancellationToken);
        }

        public Task<string> AddToReinsertPotRequestAsync(AddToReinsertPotFunction addToReinsertPotFunction)
        {
             return ContractHandler.SendRequestAsync(addToReinsertPotFunction);
        }

        public Task<string> AddToReinsertPotRequestAsync()
        {
             return ContractHandler.SendRequestAsync<AddToReinsertPotFunction>();
        }

        public Task<TransactionReceipt> AddToReinsertPotRequestAndWaitForReceiptAsync(AddToReinsertPotFunction addToReinsertPotFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addToReinsertPotFunction, cancellationToken);
        }

        public Task<TransactionReceipt> AddToReinsertPotRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<AddToReinsertPotFunction>(null, cancellationToken);
        }

        public Task<BigInteger> DelegatorShareQueryAsync(DelegatorShareFunction delegatorShareFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DelegatorShareFunction, BigInteger>(delegatorShareFunction, blockParameter);
        }

        
        public Task<BigInteger> DelegatorShareQueryAsync(BigInteger stakingEpoch, BigInteger delegatorStaked, BigInteger validatorStaked, BigInteger totalStaked, BigInteger poolReward, BlockParameter blockParameter = null)
        {
            var delegatorShareFunction = new DelegatorShareFunction();
                delegatorShareFunction.StakingEpoch = stakingEpoch;
                delegatorShareFunction.DelegatorStaked = delegatorStaked;
                delegatorShareFunction.ValidatorStaked = validatorStaked;
                delegatorShareFunction.TotalStaked = totalStaked;
                delegatorShareFunction.PoolReward = poolReward;
            
            return ContractHandler.QueryAsync<DelegatorShareFunction, BigInteger>(delegatorShareFunction, blockParameter);
        }

        public Task<BigInteger> DeltaPotQueryAsync(DeltaPotFunction deltaPotFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DeltaPotFunction, BigInteger>(deltaPotFunction, blockParameter);
        }

        
        public Task<BigInteger> DeltaPotQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DeltaPotFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> DeltaPotPayoutFractionQueryAsync(DeltaPotPayoutFractionFunction deltaPotPayoutFractionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DeltaPotPayoutFractionFunction, BigInteger>(deltaPotPayoutFractionFunction, blockParameter);
        }

        
        public Task<BigInteger> DeltaPotPayoutFractionQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DeltaPotPayoutFractionFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> EpochPoolNativeRewardQueryAsync(EpochPoolNativeRewardFunction epochPoolNativeRewardFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<EpochPoolNativeRewardFunction, BigInteger>(epochPoolNativeRewardFunction, blockParameter);
        }

        
        public Task<BigInteger> EpochPoolNativeRewardQueryAsync(BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var epochPoolNativeRewardFunction = new EpochPoolNativeRewardFunction();
                epochPoolNativeRewardFunction.ReturnValue1 = returnValue1;
                epochPoolNativeRewardFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<EpochPoolNativeRewardFunction, BigInteger>(epochPoolNativeRewardFunction, blockParameter);
        }

        public Task<List<BigInteger>> EpochsPoolGotRewardForQueryAsync(EpochsPoolGotRewardForFunction epochsPoolGotRewardForFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<EpochsPoolGotRewardForFunction, List<BigInteger>>(epochsPoolGotRewardForFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> EpochsPoolGotRewardForQueryAsync(string miningAddress, BlockParameter blockParameter = null)
        {
            var epochsPoolGotRewardForFunction = new EpochsPoolGotRewardForFunction();
                epochsPoolGotRewardForFunction.MiningAddress = miningAddress;
            
            return ContractHandler.QueryAsync<EpochsPoolGotRewardForFunction, List<BigInteger>>(epochsPoolGotRewardForFunction, blockParameter);
        }

        public Task<List<BigInteger>> EpochsToClaimRewardFromQueryAsync(EpochsToClaimRewardFromFunction epochsToClaimRewardFromFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<EpochsToClaimRewardFromFunction, List<BigInteger>>(epochsToClaimRewardFromFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> EpochsToClaimRewardFromQueryAsync(string poolStakingAddress, string staker, BlockParameter blockParameter = null)
        {
            var epochsToClaimRewardFromFunction = new EpochsToClaimRewardFromFunction();
                epochsToClaimRewardFromFunction.PoolStakingAddress = poolStakingAddress;
                epochsToClaimRewardFromFunction.Staker = staker;
            
            return ContractHandler.QueryAsync<EpochsToClaimRewardFromFunction, List<BigInteger>>(epochsToClaimRewardFromFunction, blockParameter);
        }

        public Task<string> GovernancePotAddressQueryAsync(GovernancePotAddressFunction governancePotAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GovernancePotAddressFunction, string>(governancePotAddressFunction, blockParameter);
        }

        
        public Task<string> GovernancePotAddressQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GovernancePotAddressFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> GovernancePotShareDenominatorQueryAsync(GovernancePotShareDenominatorFunction governancePotShareDenominatorFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GovernancePotShareDenominatorFunction, BigInteger>(governancePotShareDenominatorFunction, blockParameter);
        }

        
        public Task<BigInteger> GovernancePotShareDenominatorQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GovernancePotShareDenominatorFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> GovernancePotShareNominatorQueryAsync(GovernancePotShareNominatorFunction governancePotShareNominatorFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GovernancePotShareNominatorFunction, BigInteger>(governancePotShareNominatorFunction, blockParameter);
        }

        
        public Task<BigInteger> GovernancePotShareNominatorQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GovernancePotShareNominatorFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(string validatorSet)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ValidatorSet = validatorSet;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(string validatorSet, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ValidatorSet = validatorSet;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<bool> IsInitializedQueryAsync(IsInitializedFunction isInitializedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsInitializedFunction, bool>(isInitializedFunction, blockParameter);
        }

        
        public Task<bool> IsInitializedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsInitializedFunction, bool>(null, blockParameter);
        }

        public Task<BigInteger> NativeRewardUndistributedQueryAsync(NativeRewardUndistributedFunction nativeRewardUndistributedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NativeRewardUndistributedFunction, BigInteger>(nativeRewardUndistributedFunction, blockParameter);
        }

        
        public Task<BigInteger> NativeRewardUndistributedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NativeRewardUndistributedFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> ReinsertPotQueryAsync(ReinsertPotFunction reinsertPotFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ReinsertPotFunction, BigInteger>(reinsertPotFunction, blockParameter);
        }

        
        public Task<BigInteger> ReinsertPotQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ReinsertPotFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> ReinsertPotPayoutFractionQueryAsync(ReinsertPotPayoutFractionFunction reinsertPotPayoutFractionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ReinsertPotPayoutFractionFunction, BigInteger>(reinsertPotPayoutFractionFunction, blockParameter);
        }

        
        public Task<BigInteger> ReinsertPotPayoutFractionQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ReinsertPotPayoutFractionFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> RewardRequestAsync(RewardFunction rewardFunction)
        {
             return ContractHandler.SendRequestAsync(rewardFunction);
        }

        public Task<TransactionReceipt> RewardRequestAndWaitForReceiptAsync(RewardFunction rewardFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rewardFunction, cancellationToken);
        }

        public Task<string> RewardRequestAsync(bool isEpochEndBlock)
        {
            var rewardFunction = new RewardFunction();
                rewardFunction.IsEpochEndBlock = isEpochEndBlock;
            
             return ContractHandler.SendRequestAsync(rewardFunction);
        }

        public Task<TransactionReceipt> RewardRequestAndWaitForReceiptAsync(bool isEpochEndBlock, CancellationTokenSource cancellationToken = null)
        {
            var rewardFunction = new RewardFunction();
                rewardFunction.IsEpochEndBlock = isEpochEndBlock;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rewardFunction, cancellationToken);
        }

        public Task<string> SetReinsertPotPayoutFractionRequestAsync(SetReinsertPotPayoutFractionFunction setReinsertPotPayoutFractionFunction)
        {
             return ContractHandler.SendRequestAsync(setReinsertPotPayoutFractionFunction);
        }

        public Task<TransactionReceipt> SetReinsertPotPayoutFractionRequestAndWaitForReceiptAsync(SetReinsertPotPayoutFractionFunction setReinsertPotPayoutFractionFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setReinsertPotPayoutFractionFunction, cancellationToken);
        }

        public Task<string> SetReinsertPotPayoutFractionRequestAsync(BigInteger value)
        {
            var setReinsertPotPayoutFractionFunction = new SetReinsertPotPayoutFractionFunction();
                setReinsertPotPayoutFractionFunction.Value = value;
            
             return ContractHandler.SendRequestAsync(setReinsertPotPayoutFractionFunction);
        }

        public Task<TransactionReceipt> SetReinsertPotPayoutFractionRequestAndWaitForReceiptAsync(BigInteger value, CancellationTokenSource cancellationToken = null)
        {
            var setReinsertPotPayoutFractionFunction = new SetReinsertPotPayoutFractionFunction();
                setReinsertPotPayoutFractionFunction.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setReinsertPotPayoutFractionFunction, cancellationToken);
        }

        public Task<string> SetdeltaPotPayoutFractionRequestAsync(SetdeltaPotPayoutFractionFunction setdeltaPotPayoutFractionFunction)
        {
             return ContractHandler.SendRequestAsync(setdeltaPotPayoutFractionFunction);
        }

        public Task<TransactionReceipt> SetdeltaPotPayoutFractionRequestAndWaitForReceiptAsync(SetdeltaPotPayoutFractionFunction setdeltaPotPayoutFractionFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setdeltaPotPayoutFractionFunction, cancellationToken);
        }

        public Task<string> SetdeltaPotPayoutFractionRequestAsync(BigInteger value)
        {
            var setdeltaPotPayoutFractionFunction = new SetdeltaPotPayoutFractionFunction();
                setdeltaPotPayoutFractionFunction.Value = value;
            
             return ContractHandler.SendRequestAsync(setdeltaPotPayoutFractionFunction);
        }

        public Task<TransactionReceipt> SetdeltaPotPayoutFractionRequestAndWaitForReceiptAsync(BigInteger value, CancellationTokenSource cancellationToken = null)
        {
            var setdeltaPotPayoutFractionFunction = new SetdeltaPotPayoutFractionFunction();
                setdeltaPotPayoutFractionFunction.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setdeltaPotPayoutFractionFunction, cancellationToken);
        }

        public Task<BigInteger> SnapshotPoolTotalStakeAmountQueryAsync(SnapshotPoolTotalStakeAmountFunction snapshotPoolTotalStakeAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SnapshotPoolTotalStakeAmountFunction, BigInteger>(snapshotPoolTotalStakeAmountFunction, blockParameter);
        }

        
        public Task<BigInteger> SnapshotPoolTotalStakeAmountQueryAsync(BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var snapshotPoolTotalStakeAmountFunction = new SnapshotPoolTotalStakeAmountFunction();
                snapshotPoolTotalStakeAmountFunction.ReturnValue1 = returnValue1;
                snapshotPoolTotalStakeAmountFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<SnapshotPoolTotalStakeAmountFunction, BigInteger>(snapshotPoolTotalStakeAmountFunction, blockParameter);
        }

        public Task<BigInteger> SnapshotPoolValidatorStakeAmountQueryAsync(SnapshotPoolValidatorStakeAmountFunction snapshotPoolValidatorStakeAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SnapshotPoolValidatorStakeAmountFunction, BigInteger>(snapshotPoolValidatorStakeAmountFunction, blockParameter);
        }

        
        public Task<BigInteger> SnapshotPoolValidatorStakeAmountQueryAsync(BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var snapshotPoolValidatorStakeAmountFunction = new SnapshotPoolValidatorStakeAmountFunction();
                snapshotPoolValidatorStakeAmountFunction.ReturnValue1 = returnValue1;
                snapshotPoolValidatorStakeAmountFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<SnapshotPoolValidatorStakeAmountFunction, BigInteger>(snapshotPoolValidatorStakeAmountFunction, blockParameter);
        }

        public Task<BigInteger> ValidatorMinRewardPercentQueryAsync(ValidatorMinRewardPercentFunction validatorMinRewardPercentFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorMinRewardPercentFunction, BigInteger>(validatorMinRewardPercentFunction, blockParameter);
        }

        
        public Task<BigInteger> ValidatorMinRewardPercentQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var validatorMinRewardPercentFunction = new ValidatorMinRewardPercentFunction();
                validatorMinRewardPercentFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ValidatorMinRewardPercentFunction, BigInteger>(validatorMinRewardPercentFunction, blockParameter);
        }

        public Task<BigInteger> ValidatorRewardPercentQueryAsync(ValidatorRewardPercentFunction validatorRewardPercentFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorRewardPercentFunction, BigInteger>(validatorRewardPercentFunction, blockParameter);
        }

        
        public Task<BigInteger> ValidatorRewardPercentQueryAsync(string stakingAddress, BlockParameter blockParameter = null)
        {
            var validatorRewardPercentFunction = new ValidatorRewardPercentFunction();
                validatorRewardPercentFunction.StakingAddress = stakingAddress;
            
            return ContractHandler.QueryAsync<ValidatorRewardPercentFunction, BigInteger>(validatorRewardPercentFunction, blockParameter);
        }

        public Task<string> ValidatorSetContractQueryAsync(ValidatorSetContractFunction validatorSetContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorSetContractFunction, string>(validatorSetContractFunction, blockParameter);
        }

        
        public Task<string> ValidatorSetContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorSetContractFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> ValidatorShareQueryAsync(ValidatorShareFunction validatorShareFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorShareFunction, BigInteger>(validatorShareFunction, blockParameter);
        }

        
        public Task<BigInteger> ValidatorShareQueryAsync(BigInteger stakingEpoch, BigInteger validatorStaked, BigInteger totalStaked, BigInteger poolReward, BlockParameter blockParameter = null)
        {
            var validatorShareFunction = new ValidatorShareFunction();
                validatorShareFunction.StakingEpoch = stakingEpoch;
                validatorShareFunction.ValidatorStaked = validatorStaked;
                validatorShareFunction.TotalStaked = totalStaked;
                validatorShareFunction.PoolReward = poolReward;
            
            return ContractHandler.QueryAsync<ValidatorShareFunction, BigInteger>(validatorShareFunction, blockParameter);
        }

        public Task<string> TransferRewardRequestAsync(TransferRewardFunction transferRewardFunction)
        {
             return ContractHandler.SendRequestAsync(transferRewardFunction);
        }

        public Task<TransactionReceipt> TransferRewardRequestAndWaitForReceiptAsync(TransferRewardFunction transferRewardFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferRewardFunction, cancellationToken);
        }

        public Task<string> TransferRewardRequestAsync(BigInteger nativeCoins, string to)
        {
            var transferRewardFunction = new TransferRewardFunction();
                transferRewardFunction.NativeCoins = nativeCoins;
                transferRewardFunction.To = to;
            
             return ContractHandler.SendRequestAsync(transferRewardFunction);
        }

        public Task<TransactionReceipt> TransferRewardRequestAndWaitForReceiptAsync(BigInteger nativeCoins, string to, CancellationTokenSource cancellationToken = null)
        {
            var transferRewardFunction = new TransferRewardFunction();
                transferRewardFunction.NativeCoins = nativeCoins;
                transferRewardFunction.To = to;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferRewardFunction, cancellationToken);
        }

        public Task<BigInteger> GetDelegatorRewardQueryAsync(GetDelegatorRewardFunction getDelegatorRewardFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetDelegatorRewardFunction, BigInteger>(getDelegatorRewardFunction, blockParameter);
        }

        
        public Task<BigInteger> GetDelegatorRewardQueryAsync(BigInteger delegatorStake, BigInteger stakingEpoch, string poolMiningAddress, BlockParameter blockParameter = null)
        {
            var getDelegatorRewardFunction = new GetDelegatorRewardFunction();
                getDelegatorRewardFunction.DelegatorStake = delegatorStake;
                getDelegatorRewardFunction.StakingEpoch = stakingEpoch;
                getDelegatorRewardFunction.PoolMiningAddress = poolMiningAddress;
            
            return ContractHandler.QueryAsync<GetDelegatorRewardFunction, BigInteger>(getDelegatorRewardFunction, blockParameter);
        }

        public Task<BigInteger> GetValidatorRewardQueryAsync(GetValidatorRewardFunction getValidatorRewardFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValidatorRewardFunction, BigInteger>(getValidatorRewardFunction, blockParameter);
        }

        
        public Task<BigInteger> GetValidatorRewardQueryAsync(BigInteger stakingEpoch, string poolMiningAddress, BlockParameter blockParameter = null)
        {
            var getValidatorRewardFunction = new GetValidatorRewardFunction();
                getValidatorRewardFunction.StakingEpoch = stakingEpoch;
                getValidatorRewardFunction.PoolMiningAddress = poolMiningAddress;
            
            return ContractHandler.QueryAsync<GetValidatorRewardFunction, BigInteger>(getValidatorRewardFunction, blockParameter);
        }
    }
}
